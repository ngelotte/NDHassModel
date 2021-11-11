using System;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using System.Collections.Generic;
using NetDaemon.Common;
using NetDaemon.HassModel.Common;
using Microsoft.Extensions.Logging;
using NdGreenhouse;
using NetDaemon.Extensions.Scheduler;

namespace NdGreenhouse.Apps.Greenhouse
{
    [Focus]
    [NetDaemonApp]
    public class GrowLightApp : IDisposable
    {
        private IHaContext haContext { get; set; } = default!;
        private ILogger<GrowLightApp> _logger { get; set; } = default!;
        public INetDaemonScheduler _scheduler { get; set; } = default!;
        public double? ElevationEvening { get; set; }
        public double? ElevationMorning { get; set; }
        public string NightEndTime { get; set; } = "";
        public string MorningStartTime { get; set; } = "";
        public IList<SwitchEntity>? GrowLights { get; set; }
        public GrowLightApp(IHaContext ha, ILogger<GrowLightApp> logger, INetDaemonScheduler scheduler)
        {
            _logger = logger;
            haContext = ha;
            _scheduler = scheduler;
            InitNightTime(ha);
            InitTurnOnLightsInTheMorning(ha);
        }

        private void InitNightTime(IHaContext ha)
        {
            if (NightEndTime != null && ElevationEvening != null && GrowLights != null)
            {
                SunEntities sunEntities = new SunEntities(ha);
                sunEntities.Sun
                    .StateAllChanges
                    .Where(e =>
                        e.New?.Attributes?.Elevation <= ElevationEvening &&
                        e.New?.Attributes?.Rising == false &&
                        e.Old?.Attributes?.Elevation > ElevationEvening
                        )
                    .Subscribe(s =>
                    {
                        DateTime currentTime = DateTime.Now;
                        DateTime todaysEndTime = currentTime.Date.Add(TimeSpan.Parse(NightEndTime));
                        if (todaysEndTime >= DateTime.Now.AddMinutes(1))
                        {
                            _logger.LogInformation($"Turning on the Lights at {DateTime.Now}");
                            GrowLights.TurnOn();
                        }
                        else
                        {
                            _logger.LogInformation($"Skipping turning on the Lights because it is {currentTime} but Night End Time is {todaysEndTime}");
                        }
                    });
            }
            if (NightEndTime != null && GrowLights != null)
            {
                //I have absolutely no idea if this parses correctly. 
                DateTimeOffset firstTimeToStart = DateTimeOffset.Parse(NightEndTime);
                _scheduler.RunDaily(TimeSpan.Parse(MorningStartTime), () =>
                                {
                                    GrowLights.TurnOff();
                                    _logger.LogInformation($"Turning off the Lights at {DateTime.Now}");
                                });
            }


        }

        private void InitTurnOnLightsInTheMorning(IHaContext ha)
        {
            SunEntities sunEntities = new SunEntities(ha);
            if (MorningStartTime != null && ElevationMorning != null && GrowLights != null)
            {//I have absolutely no idea if this parses correctly. 
                DateTimeOffset firstTimeToStart = DateTimeOffset.Parse(MorningStartTime);
                _scheduler.RunEvery(TimeSpan.FromHours(24), firstTimeToStart, () =>
                   {
                       if (sunEntities != null && sunEntities?.Sun?.Attributes != null)
                       {
                           if (sunEntities.Sun.Attributes.Elevation < ElevationMorning)
                           {
                               _logger.LogInformation($"Turning on the Lights at {DateTime.Now}");
                               GrowLights.TurnOn();

                           }
                           else
                           {
                               _logger.LogInformation($"Skipping turning on the Lights because the sun is at  {sunEntities.Sun.Attributes.Elevation} but it needs to be below {ElevationMorning}");
                           }

                       }
                       else
                       {
                           _logger.LogInformation($"Sun attributes is null. So not turning on the lights because we dont know where the sun is.");
                       }

                   }
           );


            }
            //
            if (MorningStartTime != null && ElevationMorning != null && GrowLights != null)
            {
                sunEntities.Sun
                            .StateAllChanges
                            .Where(e =>
                                e.New?.Attributes?.Elevation >= ElevationMorning &&
                                e.New?.Attributes?.Rising == true &&
                                e.Old?.Attributes?.Elevation < ElevationMorning
                                )
                            .Subscribe(s =>
                            {
                                GrowLights.TurnOff();
                                _logger.LogInformation($"Turning off the Lights at {DateTime.Now}");
                            }

                        );
            }


        }

        public void Dispose()
        {

        }
    }
}

