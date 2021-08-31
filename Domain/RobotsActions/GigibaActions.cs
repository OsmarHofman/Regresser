using Regresser.Domain.Shipper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Regresser.Domain.RobotsActions
{
    public class GigibaActions : Actions
    {
        public string UrlWs { get; set; }

        public List<Nfe> Nfes { get; set; }

        public override string ToString()
        {
            return $"{Nfes.First()} Url do Ws: {UrlWs}.";
        }

        public override TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode> { new TreeNode($"Url do WS: {UrlWs}") };

            foreach (var nfe in Nfes) treeNodes.Add(nfe.ToStringAsTreeNodes());

            return new TreeNode("Actions", treeNodes.ToArray());
        }
    }
}
