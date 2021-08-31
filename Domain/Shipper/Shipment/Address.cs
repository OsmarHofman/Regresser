using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Regresser.Domain.Shipper
{
    public class Address
    {
        public string City { get; set; }

        public string State { get; set; }

        public string IBGE { get; set; }

        public TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>
            {
                new TreeNode($"Cidade: {City}"),
                new TreeNode($"Estado: {State}"),
                new TreeNode($"IBGE: {IBGE}")
            };

            return new TreeNode("Endereço", treeNodes.ToArray());
        }
    }
}
