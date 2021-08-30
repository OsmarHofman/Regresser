using Regresser.Domain.Shipper;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Regresser.Domain.RobotsActions
{
    public class GigibaActions : Actions
    {
        public String UrlWs { get; set; }

        public List<Nfe> Nfes { get; set; }

        public override string ToString()
        {
            return $"{Nfes.First()} Url do Ws: {UrlWs}.";
        }
    }
}
