using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.IO;

namespace RuleEngine
{
    public class RuleEngine
    {
        public static bool ValidatePaymentType(int paymentType)
        {

            return true;
        }

        public static void PaymentProcessing()
        {
            string paymentJson = File.ReadAllText("PaymentType.json");

            var payment = JsonConvert.DeserializeObject<PaymentAttributes>(paymentJson,
                new StringEnumConverter());

            switch (payment.paymentType)
            {
                case RuleEnginePaymentTypes.PhysicalProduct:
                    int packingSlipID = PaymentRuleAction.GeneratePackingSlip();
                    break;

                case RuleEnginePaymentTypes.Book:
                    int dupPackingSlipId = PaymentRuleAction.GeneratePackingSlipRoyalDept();
                    break;

                case RuleEnginePaymentTypes.NewMembership:
                    int membershipID = PaymentRuleAction.ActivateMembership();
                    break;

                case RuleEnginePaymentTypes.UpgradeMembership:
                    bool upgradeMemID = PaymentRuleAction.UpgradeMembership();
                    break;

                case RuleEnginePaymentTypes.Video:
                    PaymentRuleAction.AddFreeVideo();
                    break;

                default:
                    break;
            }
        }

      
    }
}
