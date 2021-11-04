using System.Collections.Generic;
using System.Windows.Forms;

namespace Regresser.Domain.Shipper
{
    public class ShipmentStatus
    {
        public string StatusXid { get; set; }

        public TreeNode ToStringAsTreeNodes()
        {
            return new TreeNode($"Xid da Ocorrência: {StatusXid}");
        }

        public override string ToString()
        {
            return StatusXid;
        }
    }
}
