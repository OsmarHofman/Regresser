﻿using Regresser.Domain.Shipper;
using System.Collections.Generic;
using System.Linq;

namespace Regresser.Domain.RobotsActions
{
    public class JarvisActions : Actions
    {
        public string UrlWs { get; set; }

        public List<Shipment> Shipments { get; set; }

        public override string ToString()
        {
            return $"{Shipments.First()} Url do Ws: {UrlWs}.";
        }
    }
}
