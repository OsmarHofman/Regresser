using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Regresser.Domain.Shipper
{
    public class Nfe
    {
        public string EnterpriseId { get; set; }

        public string Token { get; set; }

        public string Issuer { get; set; }

        public string Recipient { get; set; }

        public string DomainNameXidRelease { get; set; }

        public string Number { get; set; }

        public string AccessKey { get; set; }

        public override string ToString()
        {
            return $"Nfe número {Number} para release(s): {DomainNameXidRelease}. " +
                $"Emissor: {Issuer}; Recebedor: {Recipient}. " +
                $"Token: {Token}; EnterpriseId: {EnterpriseId}.";
        }

        public TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>
            {
                new TreeNode($"EnterpriseId: {EnterpriseId}"),
                new TreeNode($"Token: {Token}"),
                new TreeNode($"Emissor: {Issuer}"),
                new TreeNode($"Recebedor: {Recipient}"),
                new TreeNode($"Ordem(ns) vinculada(s): {DomainNameXidRelease}"),
                new TreeNode($"Recebedor: {Recipient}"),
            };

            return new TreeNode($"NF-e: {Number}", treeNodes.ToArray());
        }
    }
}
