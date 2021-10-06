using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Regresser.Domain.RobotsActions
{
    public class DBAActions : Actions
    {
        public string Server { get; set; }

        public string ServerUser { get; set; }

        public string ServerPassword { get; set; }

        public string ShipperContext { get; set; }

        public string MonitoringContext { get; set; }

        public string PaymentContext { get; set; }

        public string QueryString { get; set; }

        public List<DBAResult> Results { get; set; }

        public override TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>
            {
                new TreeNode($"IP do Servidor: {Server}"),
                new TreeNode($"Usuário do Servidor: {ServerUser}"),
                new TreeNode($"Senha do Servidor: {ServerPassword}"),
                new TreeNode($"Contexto do Shipper: {ShipperContext}"),
                new TreeNode($"Contexto do Monitoring: {MonitoringContext}"),
                new TreeNode($"Contexto do Payment: {PaymentContext}"),
                new TreeNode($"Consulta: {QueryString}"),
            };

            foreach (var result in Results) treeNodes.Add(result.ToStringAsTreeNodes());

            return new TreeNode("Actions", treeNodes.ToArray());
        }
    }
}
