using System;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using System.Threading.Tasks;
using NetDaemon.Common;
using System.Collections.Generic;
using System.Linq;
using NetDaemon.HassModel.Common;
using Microsoft.Extensions.Logging;
using System.Reactive.Concurrency;
using NdGreenhouse;
using NetDaemon.HassModel.Entities;


namespace NdGreenhouse.Apps.Greenhouse
{
    [Focus]
    [NetDaemonApp]
    public class PirLightsApp : IDisposable
    {
        private IHaContext haContext { get; set; } = default!;
        private ILogger<PirLightsApp> _logger { get; set; } = default!;
        private IScheduler scheduler { get; set; } = default!;
        private bool HoldCurrentZoneIsRunning { get; set; } = false;

        public double? SunElevation { get; set; }
        public IList<SwitchEntity>? Lights { get; init; }
        public IList<SensorEntity>? PirSensors { get; set; }
        public int LeaveLightsOnForSeconds { get; set; }

        public PirLightsApp(IHaContext ha, ILogger<PirLightsApp> logger) : this(ha, DefaultScheduler.Instance, logger)
        { }

        public PirLightsApp(IHaContext ha, IScheduler scheduler, ILogger<PirLightsApp> logger)
        {
            haContext = ha;
            _logger = logger;

            _logger.LogInformation("Pir App Initializing");
            SunEntities sunEntities = new SunEntities(haContext);
            if (Lights != null && PirSensors != null && SunElevation != null)
            {
                _logger.LogInformation("Pir App is running");

                var entities = new Entities(haContext);
                PirSensors.StateAllChanges()
                        .Where(e => e.New?.State == "on")
                        .Subscribe(e =>
                        {
                            if (sunEntities.Sun.Attributes != null)
                            {
                                if (sunEntities.Sun.Attributes.Elevation < SunElevation)
                                {
                                    Lights.TurnOn();
                                }
                                else
                                {
                                    _logger.LogInformation($"Did not turn on the lights because the current sun elevation is {sunEntities.Sun.Attributes.Elevation} which is more then {SunElevation}");
                                }
                            }
                            else
                            {
                                _logger.LogInformation($"Sun entities is null. Nothing is going to work.");
                            }
                        });



                PirSensors.StateChanges()
                    .Where(e =>
                        (e.New?.State == "off" &&
                        e.Old?.State == "on") || (e.New?.State == "on" &&
                        e.Old?.State == "off")
                    )
                    .Throttle(TimeSpan.FromSeconds(LeaveLightsOnForSeconds))
                    .Subscribe(e =>
                    {
                        if (e.New.State == "off")
                        {
                            _logger.LogInformation("Turning Lights Off");
                            Lights.TurnOff();
                        }
                    });
            }
            else
            {
                _logger.LogInformation("Pir App is not running");
                if (Lights == null)
                {
                    _logger.LogInformation("Lights is null pulling from the yaml so the automation could not start.");
                }
                if (PirSensors == null)
                {
                    _logger.LogInformation("PirSensors is null pulling from the yaml so the automation could not start.");
                }
                if (SunElevation == null)
                {
                    _logger.LogInformation("ElevationEvening is null pulling from the yaml so the automation could not start.");
                }

            }

            //var entities = new Entities(ha);

            //entities.InputSelect.ReservoirRes.SelectOption("DB2");
            //ha.CallService("input_select", "select_option",null, new { target = new { entity_id = "input_select.reservoir_res" }, option = "DB2" });
        }


        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }

}
