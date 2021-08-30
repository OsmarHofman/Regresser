using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.Shipper
{
    public class Nfe
    {
        public string EnterpriseId { get; set; }

        public string Token { get; set; }

        public string Issuer { get; set; }

        public string Recipient { get; set; }

        public string DomainNameXidRelease { get; set; }

        public string Number { get; set; }

        public string AccessKey { get; set; }

        public override string ToString()
        {
            return $"Nfe número {Number} para release(s): {DomainNameXidRelease}. " +
                $"Emissor: {Issuer}; Recebedor: {Recipient}. " +
                $"Token: {Token}; EnterpriseId: {EnterpriseId}.";
        }
    }
}
