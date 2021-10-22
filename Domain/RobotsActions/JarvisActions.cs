using Regresser.Domain.Shipper;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

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

        public override TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>();

            foreach (var shipment in Shipments) treeNodes.Add(shipment.ToStringAsTreeNodes());

            return new TreeNode("Actions", treeNodes.ToArray());
        }
    }
}
