using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        public string TollCalculation { get; set; }

        public string TollPayment { get; set; }

        public string DriverXid { get; set; }

        public Address SourceAddress { get; set; }

        public List<Refnum> ShipmentRefnums { get; set; }

        public List<ShipmentCost> ShipmentCosts { get; set; }

        public List<Release> Releases { get; set; }

        public override string ToString()
        {
            return $"Embarque {ShipmentXid}; {TravelStatus}; " +
                $"Custo Total: {ShipmentCosts.Sum(x => x.Value)}; Qtd Ordens: {Releases.Count}.";
        }

        public TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>
            {
                new TreeNode($"Status da Viagem: {TravelStatus}"),
                new TreeNode($"Status de Emissão: {EmissionStatus}"),
                new TreeNode($"Transportador: {XidCarrier}"),
                new TreeNode($"Origem: {XidSourceLocation}"),
                new TreeNode($"Destino: {XidDestinationLocation}"),
                new TreeNode($"Tomador: {XidTakerLocation}"),
                new TreeNode($"Imposto Somado: {AddedTax}"),
                new TreeNode($"Imposto Incluso: {TaxIncluded}"),
                new TreeNode($"Cálculo do Pedágio: {TollCalculation}"),
                new TreeNode($"Pagamento do Pedágio: {TollPayment}"),

            };

            if (!string.IsNullOrEmpty(DriverXid))
                treeNodes.Add(new TreeNode($"Motorista: {DriverXid}"));

            if (SourceAddress != null)
                treeNodes.Add(SourceAddress.ToStringAsTreeNodes());

            if (ShipmentCosts != null)
                foreach (var shipmentCost in ShipmentCosts) treeNodes.Add(shipmentCost.ToStringAsTreeNodes());

            if (ShipmentRefnums != null)
            {
                List<TreeNode> refnums = new List<TreeNode>();
                foreach (var shipmentRefnum in ShipmentRefnums) refnums.Add(shipmentRefnum.ToStringAsTreeNodes());
                treeNodes.Add(new TreeNode("Refnums do Embarque", refnums.ToArray()));
            }

            if (Releases != null)
                foreach (var release in Releases) treeNodes.Add(release.ToStringAsTreeNodes());


            return new TreeNode($"Embarque: {ShipmentDomainName}.{ShipmentXid}", treeNodes.ToArray());
        }
    }
}
