using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Regresser.Domain.Shipper
{
    public class Release
    {
        public string ReleaseDomainName { get; set; }

        public string ReleaseXid { get; set; }

        public List<Refnum> ReleaseRefnums { get; set; }

        public TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>();

            if (ReleaseRefnums.Any())
                foreach (var refnum in ReleaseRefnums) treeNodes.Add(refnum.ToStringAsTreeNodes());

            return new TreeNode($"Ordem: {ReleaseDomainName}.{ReleaseXid}", treeNodes.ToArray());
        }
    }
}