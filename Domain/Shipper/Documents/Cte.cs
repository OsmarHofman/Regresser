using System;
using System.Collections.Generic;
using System.Text;

namespace Regresser.Domain.Shipper
{
    public class Cte
    {
        public string EnterpriseId { get; set; }

        public string Token { get; set; }

        public string Emitter { get; set; }

        public string Sender { get; set; }

        public string Recipient { get; set; }

        public List<string> NfeNumbers { get; set; }

        public List<string> NfeAccessKeys { get; set; }

        public string Number { get; set; }

        public bool? GlobalCTe { get; set; }

        public decimal Value { get; set; }

        public Icms Icms { get; set; }

        public override string ToString()
        {
            return $"Cte número {Number} com valor: {Value} para release(s): {String.Join(", ", NfeNumbers.ToArray())}. " +
                $"Emissor: {Emitter}; Remetente: {Sender}; Recebedor: {Recipient}. " +
                $"Token: {Token}; EnterpriseId: {EnterpriseId}. ";
        }
    }
}
