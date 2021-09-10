using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.Shipper.Documents
{
    public class ComplementaryCte : Cte
    {
        public string CteNorm { get; set; }

        public override string ToString()
        {
            return $"CTe vinculado ao CTe Complementar: {CteNorm} ";
        }
    }
}
