using Regresser.Domain.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.Shipper
{
    public class Icms
    {

        public ICMSType IcmsType { get; set; }

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
    }
}
