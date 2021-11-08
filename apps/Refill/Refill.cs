using System;
using System.Reactive.Linq;
using NetDaemon.Common.Reactive;
using System.Threading.Tasks;
using NetDaemon.Common;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using Microsoft.Extensions.Logging;
using NetDaemon.HassModel.Common;
using System.Reactive.Concurrency;

// Use unique namespaces for your apps if you going to share with others to avoid
// conflicting names
namespace NdGreenhouse.Apps.Greenhouse
{
    /// <summary>
    ///     The NetDaemonApp implements async model API
    ///     This API are deprecated please use the Rx one!
    /// </summary>
    public class RefillApp : NetDaemonRxApp
    {
        private IHaContext haContext { get; set; } = default!;
        private ILogger<RefillApp> _logger { get; set; } = default!;
        private IScheduler scheduler { get; set; } = default!;
        public IEnumerable<string>? ActiveReservoirs { get; set; }

        public RefillApp(IHaContext ha, ILogger<RefillApp> logger) : this(ha, DefaultScheduler.Instance, logger)
        { }

        public RefillApp(IHaContext ha, IScheduler scheduler, ILogger<RefillApp> logger)
        {
            haContext = ha;
            _logger = logger;
            //var entities = new Entities(ha);

            //entities.InputSelect.ReservoirRes.SelectOption("DB2");
            //ha.CallService("input_select", "select_option",null, new { target = new { entity_id = "input_select.reservoir_res" }, option = "DB2" });
        }
        public override async ValueTask DisposeAsync()
        {
            GhProcedures gh = new GhProcedures(haContext, _logger);
            gh.MakeSureEverythingisOff();
            LogInformation("Made sure everythign is off");

        }
        public override void Initialize()
        {
            LogInformation("Refill started and is ready for a callback");
        }

        [HomeAssistantServiceCall]
        public async Task RefillCurrentZone(dynamic data)
        {

            GhProcedures gh = new GhProcedures(haContext, _logger);
            await gh.RefillCurrentReservior();

        }


        [HomeAssistantServiceCall]
        public async Task RefillWaterTank(dynamic data)
        {
            GhProcedures gh = new GhProcedures(haContext, _logger);
            await gh.RefillMainWaterTank();
        }


        [HomeAssistantServiceCall]
        public async Task RefillSwpCooler(dynamic data)
        {
            GhProcedures gh = new GhProcedures(haContext, _logger);
            await gh.RefillSwampCooler();

        }

        [HomeAssistantServiceCall]
        public async Task RunDumpRutineForCurrentZone(dynamic data)
        {
            GhProcedures gh = new GhProcedures(haContext, _logger);
            await gh.RunOneTankEmptyRunForCurrentZone();

        }


    }
}

