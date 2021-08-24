using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.Shipper
{
    public class Shipment
    {
        public string ShipmentDomainName { get; set; }

        public string ShipmentXid { get; set; }

        public string TravelStatus { get; set; }

        public string EmissionStatus { get; set; }

        public string XidCarrier { get; set; }

        public string XidSourceLocation { get; set; }

        public string XidDestinationLocation { get; set; }

        public string XidTakerLocation { get; set; }

        public string AddedTax { get; set; }

        public string TaxIncluded { get; set; }

        public string DriverXid { get; set; }

        public Address SourceAddress { get; set; }

        public Dictionary<string, string> ShipmentRefnums { get; set; }

        public List<Release> Releases { get; set; }

        public List<ShipmentCost> ShipmentCosts { get; set; }

    }
}
