using Regresser.Domain.Shipper;
using Regresser.Domain.Shipper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Regresser.Domain.RobotsActions
{
    public class BinoActions : Actions
    {
        public string UrlWs { get; set; }

        public List<Cte> Ctes { get; set; }

        public List<ComplementaryCte> ComplementaryCtes { get; set; }
        public override string ToString()
        {
            var ctesLabel = (Ctes.Any()) ? Ctes.First().ToString() : "";
            var complementaryCtesLabel = (ComplementaryCtes.Any()) ? ComplementaryCtes.First().ToString() : "";

            return $"{ctesLabel}{complementaryCtesLabel}Url do Ws: {UrlWs}.";
        }
    }
}
