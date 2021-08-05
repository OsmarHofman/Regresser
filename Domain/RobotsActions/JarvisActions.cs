using Regresser.Domain.Shipper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.RobotsActions
{
    public class JarvisActions : Actions
    {
        public string URL_WS_OTM { get; set; }

        public List<Shipment> Shipments { get; set; }
    }
}
