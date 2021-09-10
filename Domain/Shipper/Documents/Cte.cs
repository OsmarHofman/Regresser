using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Regresser.Domain.Shipper
{
    public class Cte
    {
        public string EnterpriseId { get; set; }

        public string Token { get; set; }

        public string Emitter { get; set; }

        public string Sender { get; set; }

        public string Recipient { get; set; }

        public bool RecipientIsTaker { get; set; }

        public List<string> NfeNumbers { get; set; }

        public List<string> NfeAccessKeys { get; set; }

        public string Number { get; set; }

        public bool? GlobalCTe { get; set; }

        public decimal Value { get; set; }

        public Icms Icms { get; set; }

        public override string ToString()
        {
            return $"Cte número {Number} com valor: {Value} para release(s): {String.Join(", ", NfeNumbers.ToArray())}. " +
                $"Emissor: {Emitter}; Remetente: {Sender}; Recebedor: {Recipient}. " +
                $"Token: {Token}; EnterpriseId: {EnterpriseId}. ";
        }

        public TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>
            {
                new TreeNode($"EnterpriseId: {EnterpriseId}"),
                new TreeNode($"Token: {Token}"),
                new TreeNode($"Emissor: {Emitter}"),
                new TreeNode($"Remetente: {Sender}"),
                new TreeNode($"Recebedor: {Recipient}"),
                new TreeNode($"Recebedor é o Tomador: {RecipientIsTaker}"),
            };

            if (GlobalCTe != null)
                treeNodes.Add(new TreeNode($"É CT-e Global? : {GlobalCTe}"));

            if (NfeNumbers != null)
            {
                var numberNodes = new List<TreeNode>();

                foreach (var nfeNumber in NfeNumbers) numberNodes.Add(new TreeNode(nfeNumber));

                treeNodes.Add(new TreeNode("Número das NF-es:", numberNodes.ToArray()));
            }

            if (NfeAccessKeys != null)
            {
                var acessKeysNodes = new List<TreeNode>();

                foreach (var acessKey in NfeAccessKeys) acessKeysNodes.Add(new TreeNode(acessKey));

                treeNodes.Add(new TreeNode("Chaves de acesso das NF-es:", acessKeysNodes.ToArray()));
            }

            treeNodes.Add(new TreeNode($"Valor do CT-e: {Value}"));

            if (Icms != null)
                treeNodes.Add(Icms.ToStringAsTreeNodes());

            return new TreeNode($"CT-e: {Number}", treeNodes.ToArray());
        }
    }
}
