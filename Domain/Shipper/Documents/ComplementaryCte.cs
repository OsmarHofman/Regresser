using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Regresser.Domain.Shipper.Documents
{
    public class ComplementaryCte : Cte
    {
        public string CteNorm { get; set; }

        public override string ToString()
        {
            return $"CTe vinculado ao CTe Complementar: {CteNorm} ";
        }

        public override TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>
            {
                new TreeNode($"EnterpriseId: {EnterpriseId}"),
                new TreeNode($"Token: {Token}"),
                new TreeNode($"Emissor: {Emitter}"),
                new TreeNode($"Remetente: {Sender}"),
                new TreeNode($"Recebedor: {Recipient}"),
                new TreeNode($"Recebedor é o Tomador: {RecipientIsTaker}"),
                new TreeNode($"Número do CT-e Normal vinculado: {CteNorm}"),
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

            treeNodes.Add(new TreeNode($"Valor do CT-e Complementar: {Value}"));

            if (Icms != null)
                treeNodes.Add(Icms.ToStringAsTreeNodes());

            return new TreeNode($"CT-e Complementar: {Number}", treeNodes.ToArray());
        }
    }
}
