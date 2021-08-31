using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Regresser.Domain.Shipper
{
    public class Refnum
    {

        public string RefnumKey { get; set; }

        public string RefnumValue { get; set; }

        public Refnum(string key, string value)
        {
            RefnumKey = key;
            RefnumValue = value;
        }

        public static string GetValueByKeyOnList(List<Refnum> refnums, string key)
        {
            return refnums.Single(x => x.RefnumKey == key).RefnumValue;
        }

        public static void RemoveFromRefnumList(List<Refnum> refNums, string refnumKey)
        {
            var indexToRemove = 0;
            foreach (var refnum in refNums)
            {
                if (refnum.RefnumKey == refnumKey)
                    indexToRemove = refNums.IndexOf(refnum);
            }

            refNums.RemoveAt(indexToRemove);
        }

        public TreeNode ToStringAsTreeNodes()
        {
            return new TreeNode($"Refnum: {RefnumKey} - {RefnumValue}");
        }
    }
}
