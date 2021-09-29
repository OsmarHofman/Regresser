using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.RobotsActions
{
    public class DBAActions : Actions
    {
        public string Server { get; set; }

        public string ServerUser { get; set; }

        public string ServerPassword { get; set; }

        public string ShipperContext { get; set; }

        public string MonitoringContext { get; set; }

        public string PaymentContext { get; set; }

        public string QueryString { get; set; }

        public List<DBAResult> Results { get; set; }
    }
}
