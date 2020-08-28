using System;
using System.Collections.Generic;
using System.Text;

namespace RuleEngine
{
    public class PaymentAttributes
    {
        public RuleEnginePaymentTypes paymentType { get; set; }

        public string Owner { get; set; }
        public string OwnerEmail { get; set; }
    }
}
