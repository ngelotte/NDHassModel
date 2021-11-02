using NetDaemon.Common;
using NetDaemon.Common.Reactive;
using NetDaemon.HassModel.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reactive.Concurrency;
using System.Text;
using System.Threading.Tasks;
using NetDaemon.HassModel;

namespace NdGreenhouse.Apps.Greenhouse
{
    [Focus]
    [NetDaemonApp]
    internal class RefillApp
    {
        public RefillApp(IHaContext ha) : this(ha, DefaultScheduler.Instance)
        { }

        public RefillApp(IHaContext ha, IScheduler schedulter)
        {
            var entities = new Entities(ha);
            entities.InputSelect.ReservoirRes.SelectOption("DB2");
            //ha.CallService("input_select", "select_option",null, new { target = new { entity_id = "input_select.reservoir_res" }, option = "DB2" });
        }
    }

}
