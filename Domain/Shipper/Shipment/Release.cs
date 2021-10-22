using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;

namespace Regresser.Domain.Shipper
{
    public class Release
    {
        public string ReleaseDomainName { get; set; }

        public string ReleaseXid { get; set; }

        public string DestinationLocationXid { get; set; }

        public List<Refnum> ReleaseRefnums { get; set; }

        public Release(string releaseXid)
        {
            ReleaseXid = releaseXid;
            ReleaseRefnums = new List<Refnum>();
        }

        public Release(string releaseXid, string destinationLocationXid)
        {
            ReleaseXid = releaseXid;
            DestinationLocationXid = destinationLocationXid;
            ReleaseRefnums = new List<Refnum>();
        }

        public Release(string releaseDomainName, string releaseXid, List<Refnum> releaseRefnums)
        {
            ReleaseDomainName = releaseDomainName;
            ReleaseXid = releaseXid;
            ReleaseRefnums = releaseRefnums;
        }

        public TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>();

            if (DestinationLocationXid != null)
                treeNodes.Add(new TreeNode($"Xid da location de destino: {DestinationLocationXid}"));

            if (ReleaseRefnums != null && ReleaseRefnums.Any())
                foreach (var refnum in ReleaseRefnums) treeNodes.Add(refnum.ToStringAsTreeNodes());

            return new TreeNode($"Ordem: {ReleaseDomainName}.{ReleaseXid}", treeNodes.ToArray());
        }
    }
}