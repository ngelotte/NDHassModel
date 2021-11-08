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

namespace NdGreenhouse.Apps.Greenhouse
{
    [Focus]
    [NetDaemonApp]
    public class NutrientsApp : IDisposable
    {
        private IHaContext haContext { get; set; } = default!;
        private ILogger<NutrientsApp> _logger { get; set; } = default!;
        private IScheduler scheduler { get; set; } = default!;
        private bool HoldCurrentZoneIsRunning { get; set; } = false;

        public NutrientsApp(IHaContext ha, ILogger<NutrientsApp> logger) : this(ha, DefaultScheduler.Instance, logger)
        { }

        public NutrientsApp(IHaContext ha, IScheduler scheduler, ILogger<NutrientsApp> logger)
        {
            haContext = ha;
            _logger = logger;
            GhProcedures gh = new GhProcedures(ha, logger);
            _logger.LogInformation("Nutrients is Starting");
            InputBooleanEntities ibe = new(ha);
            ibe.TestingTankHold.StateChanges.Where(t => t.New.IsOn()).Subscribe(async e =>
            {
                if (HoldCurrentZoneIsRunning == false)
                {
                    HoldCurrentZoneIsRunning = true;
                    bool completedSuccesfully = await gh.HoldCurrentZone();
                    _logger.LogInformation($"Hold currentZone completed with the completedSuccesfully set to {completedSuccesfully}");
                    HoldCurrentZoneIsRunning = false;
                }
            });
        }


        [HomeAssistantServiceCall]
        public async Task<bool> AddOneDoseToCurrentZone(dynamic data)
        {
            GhProcedures gh = new GhProcedures(haContext,_logger);
            await gh.AddNutrientsToCurrentZone();
            return true;

        }

        [HomeAssistantServiceCall]
        public async Task<bool> AddNutrient(dynamic data)
        {
            int pumpNumber = 0;
            int doses = 0;
            GhProcedures gh = new GhProcedures(haContext, _logger);
            try
            {
                pumpNumber = (int)(double)data.pumpNumber;
                doses = (int)(double)data.doses;
            }
            catch (Exception)
            {
                _logger.LogError($"Could not extract pumpNumber and Doses from data. Data is {data}");
            }
            if (pumpNumber > 0 && doses > 0)
            {
                await gh.AddNutrients(pumpNumber, doses);
            }

            return true;

        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}