using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace RuleEngine
{
    public class RuleEngine
    {
        string paymentJson = File.ReadAllText("PaymentType.json");

        //var payment = JsonConvert.DeserializeObject<PaymentAttributes>(paymentJson,
        //    new StringEnumConverter());
        public static bool ValidatePaymentType(int paymentType)
        {
            //switch (payment.paymentType)
            //{
            //    default:
            //        break;
            //}
            return true;
        }
    }
}
