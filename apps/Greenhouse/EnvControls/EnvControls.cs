using System;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using System.Threading.Tasks;
using NetDaemon.Common;
using System.Collections.Generic;
using System.Linq;
using NetDaemon.HassModel.Common;
using Microsoft.Extensions.Logging;
using NetDaemon.Extensions.Scheduler;

namespace NdGreenhouse.Apps.Greenhouse
{
    [Focus]
    [NetDaemonApp]
    public class EnvironemtnApp
    {
        private IHaContext haContext { get; set; } = default!;
        private ILogger<GrowLightApp> _logger { get; set; } = default!;
        public INetDaemonScheduler _scheduler { get; set; } = default!;
        private GhConfig _ghConfig = default!;
        //private GhZone _currentZone;
        private GHMain _ghMain = default!;
        private GhProcedures _ghProcedures = default!;
        public double? FanOnTemp { get; set; }
        public double? FanOffTemp { get; set; }
        public double? HumidityOn { get; set; }
        public double? HumidityOff { get; set; }

        public EnvironemtnApp(IHaContext ha, ILogger<EnvironemtnApp> logger, INetDaemonScheduler scheduler)
        {
            _ghConfig = new GhConfig(ha,logger);
            _ghMain = _ghConfig.GhMain();
            if (FanOnTemp < FanOffTemp)
            {
                _logger.LogError($"Fan Off Temp must be lower then Fan On Temp. Fan on temp is {FanOnTemp}. Fan Off temp is {FanOffTemp}");
                _ghProcedures.SendAlert("Environmental Controls", $"Fan Off Temp must be lower then Fan On Temp. Fan on temp is {FanOnTemp}. Fan Off temp is {FanOffTemp}");
            }
            _logger.LogInformation("EnvControls is Starting");
            scheduler.RunEvery(TimeSpan.FromMinutes(5), () =>
            {
                if (_ghMain.InternalTemp > FanOnTemp)
                {
                    if (_ghMain.MainFan.IsOff())
                    {
                        _logger.LogInformation($"Temp is {_ghMain.InternalTemp} -  Turning on the main Greenhouse Fan");
                        _ghMain.MainFan.TurnOn();
                    }
                    //LogInformation($"Internal temp is {_ghMain.InternalTemp} and external temp is {_ghMain.ExternalTemp} and Swampcooler is {_ghMain.SwampCooler.IsOff()}");
                    if ((_ghMain.InternalTemp > FanOnTemp + 5 || _ghMain.ExternalTemp > _ghMain.InternalTemp) && _ghMain.SwampCooler.IsOff())
                    {
                        _logger.LogInformation($"Temp is {_ghMain.InternalTemp} -  Turning on the swamp cooler");
                        _ghMain.SwampCooler.TurnOn();
                    }
                }
                if (_ghMain.InternalTemp < FanOffTemp)
                {
                    if (_ghMain.MainFan.IsOn())
                    {
                        _logger.LogInformation($"Temp is {_ghMain.InternalTemp} -  Turning off the main Greenhouse Fan");
                        _ghMain.MainFan.TurnOff();
                    }
                }
                if (_ghMain.ExternalTemp < _ghMain.InternalTemp && _ghMain.InternalTemp < FanOffTemp + 5 && _ghMain.SwampCooler.IsOn())
                {
                    _logger.LogInformation($"Temp is {_ghMain.InternalTemp} -  Turning off the swamp cooler");
                    _ghMain.SwampCooler.TurnOff();
                }
                if (_ghMain.InternalHumidity > HumidityOn && _ghMain.Dehumidfier.IsOff())
                {
                    _logger.LogInformation($"Humidity is {_ghMain.InternalHumidity} -  Turning on the dehumidifier");
                    _ghMain.Dehumidfier.TurnOn();


                }
                if (_ghMain.InternalHumidity < HumidityOff && _ghMain.Dehumidfier.IsOn())
                {
                    _logger.LogInformation($"Humidity is {_ghMain.InternalHumidity} -  Turning off the dehumidifier");
                    _ghMain.Dehumidfier.TurnOff();
                }
            });
        }
    }
}