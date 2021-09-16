using Regresser.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Forms;

namespace Regresser.Domain.Shipper
{
    public class Icms
    {
        public string IcmsType { get; set; }

        public string CST { get; set; }

        public decimal? vBC { get; set; }

        public decimal? pICMS { get; set; }

        public decimal? vICMS { get; set; }

        public decimal? pRedBC { get; set; }

        public decimal? vICMSSTRet { get; set; }

        public decimal? pICMSSTRet { get; set; }

        public decimal? pRedBCOutraUF { get; set; }

        public decimal? vBCOutraUF { get; set; }

        public decimal? pICMSOutraUF { get; set; }

        public decimal? vICMSOutraUF { get; set; }

        public decimal? indSN { get; set; }

        public Icms() { }

        public Icms(string IcmsTypeValue, string baseCalculation, string aliquot, string taxValue)
        {
            var invalidICMS = !IsICMSTypeCorrect(IcmsTypeValue);

            if (invalidICMS)
                throw new NotImplementedException($"ICMS: {IcmsTypeValue} não é válido!");

            IcmsType = IcmsTypeValue;
            CST = GetCSTByICMSType();
            vBC = decimal.Parse(baseCalculation);
            pICMS = decimal.Parse(aliquot);
            vICMS = decimal.Parse(taxValue);
        }

        public TreeNode ToStringAsTreeNodes()
        {
            var treeNodes = new List<TreeNode>
            {
                new TreeNode($"Tipo do ICMS: {IcmsType}"),
                new TreeNode($"CST: {CST}"),
            };

            if (vBC != null)
                treeNodes.Add(new TreeNode($"Valor da base de cálculo: {vBC}"));

            if (pICMS != null)
                treeNodes.Add(new TreeNode($"Alíquota: {pICMS}"));

            if (vICMS != null)
                treeNodes.Add(new TreeNode($"Valor do ICMS: {vICMS}"));

            if (pRedBC != null)
                treeNodes.Add(new TreeNode($"Porcentagem da redução de base de cálculo: {pRedBC}"));

            if (vICMSSTRet != null)
                treeNodes.Add(new TreeNode($"Valor do ICMS ST retido: {vICMSSTRet}"));

            if (pRedBCOutraUF != null)
                treeNodes.Add(new TreeNode($"Porcentagem da redução de base de cálculo para Outra UF: {pRedBCOutraUF}"));

            if (vBCOutraUF != null)
                treeNodes.Add(new TreeNode($"Base de cálculo para Outra UF: {vBCOutraUF}"));

            if (pICMSOutraUF != null)
                treeNodes.Add(new TreeNode($"Alíquota para Outra UF: {pICMSOutraUF}"));

            if (indSN != null)
                treeNodes.Add(new TreeNode($"É Simples Nacional: {indSN}"));


            return new TreeNode("ICMS", treeNodes.ToArray());
        }

        private bool IsICMSTypeCorrect(string value)
        {
            return value == "ICMS00" ||
               value == "ICMS20" ||
               value == "ICMS45" ||
               value == "ICMS60" ||
               value == "ICMS90" ||
               value == "ICMSOutraUF" ||
               value == "ICMSSN";
        }

        private string GetCSTByICMSType()
        {
            switch (IcmsType)
            {
                case "ICMS00":
                    return "00";

                case "ICMS20":
                    return "20";

                case "ICMS45":
                    return "40";

                case "ICMS60":
                    return "60";

                case "ICMS90":
                case "ICMSOutraUF":
                case "ICMSSN":
                    return "90";

                default:
                    return null;
            }
        }
    }
}
