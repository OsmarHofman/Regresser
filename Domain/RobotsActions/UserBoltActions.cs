using Regresser.Domain.RobotsActions;
using System.Windows.Forms;

namespace Regresser
{
    public class UserBoltActions : Actions
    {
        public string type { get; set; }

        public int timeout { get; set; }


        public override string ToString()
        {
            return $"Timeout - { timeout }";
        }

        public override TreeNode ToStringAsTreeNodes()
        {
            return new TreeNode($"{type} - {timeout}");
        }
    }
}