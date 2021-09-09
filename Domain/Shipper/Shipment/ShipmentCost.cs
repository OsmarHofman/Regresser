using System.Collections.Generic;
using System.Windows.Forms;

namespace Regresser.Domain.Shipper
{
    public class ShipmentCost
    {
        public string CostType { get; set; }

        public float Value { get; set; }

        public bool AllocateCost { get; set; }

        public string AccessorialCostXid { get; set; }

        public TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>
            {
                new TreeNode($"Tipo do Custo: {CostType}"),
                new TreeNode($"Valor: {Value}"),
                new TreeNode($"Custo alocado: {AllocateCost}"),
            };

            if (!string.IsNullOrEmpty(AccessorialCostXid))
                treeNodes.Add(new TreeNode($"Xid do custo acessório: {AccessorialCostXid}"));

            return new TreeNode("Custo do Embarque", treeNodes.ToArray());
        }
    }
}