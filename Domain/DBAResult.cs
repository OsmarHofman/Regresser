using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Regresser.Domain
{
    public class DBAResult
    {
        public int Sequence { get; set; }

        public string Value { get; set; }

        public TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>
            {
                new TreeNode($"Número da coluna a ser validado: {Sequence}"),
                new TreeNode($"Valor a ser validado: {Value}"),
            };

            return new TreeNode("Resultados a validar", treeNodes.ToArray());
        }
    }
}
