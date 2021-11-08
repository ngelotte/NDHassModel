using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using NetDaemon.HassModel.Common;
using System;
using System.Reactive.Concurrency;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace NdGreenhouse.Apps.Greenhouse
{
    [Focus]
    [NetDaemonApp]
    internal class HeatAndCo2App : IDisposable, IAsyncInitializable
    {
        private IHaContext haContext { get; set; } = default!;
        private ILogger<HeatAndCo2App> _logger { get; set; } = default!;
        private IScheduler scheduler { get; set; } = default!;
        public HeatAndCo2App(IHaContext ha, ILogger<HeatAndCo2App> logger) : this(ha, DefaultScheduler.Instance, logger)
        { }

        public HeatAndCo2App(IHaContext ha, IScheduler scheduler, ILogger<HeatAndCo2App> logger)
        {
            haContext = ha;
            _logger = logger;
            //var entities = new Entities(ha);

            //entities.InputSelect.ReservoirRes.SelectOption("DB2");
            //ha.CallService("input_select", "select_option",null, new { target = new { entity_id = "input_select.reservoir_res" }, option = "DB2" });
        }

        public void Dispose()
        {
            if (haContext != null)
            {
                var config = new GhConfig(haContext, _logger);
                config.GhMain().HomeDamper.TurnOff();

            }
        }
        public async Task InitializeAsync()
        {
            _logger.LogInformation("Starting the HeatAndCo2 App");
            GhProcedures procedures = new GhProcedures(haContext, _logger);
            await procedures.OpenHVACToGreenhouse();
        }
    }

}
