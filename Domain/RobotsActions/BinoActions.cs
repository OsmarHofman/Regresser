﻿using Regresser.Domain.Shipper;
using Regresser.Domain.Shipper.Documents;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Regresser.Domain.RobotsActions
{
    public class BinoActions : Actions
    {
        public string UrlWs { get; set; }

        public List<Cte> Ctes { get; set; }

        public List<ComplementaryCte> ComplementaryCtes { get; set; }
        public override string ToString()
        {
            var ctesLabel = (Ctes.Any()) ? Ctes.First().ToString() : "";
            var complementaryCtesLabel = (ComplementaryCtes.Any()) ? ComplementaryCtes.First().ToString() : "";

            return $"{ctesLabel}{complementaryCtesLabel}.";
        }

        public override TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>();

            if (Ctes != null)
                foreach (var cte in Ctes) treeNodes.Add(cte.ToStringAsTreeNodes());

            if (ComplementaryCtes != null)
                foreach (var cteCompl in ComplementaryCtes) treeNodes.Add(cteCompl.ToStringAsTreeNodes());


            return new TreeNode("Actions", treeNodes.ToArray());
        }
    }
}
