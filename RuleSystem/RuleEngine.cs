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
            bool validateResult = Enum.IsDefined(typeof(RuleEnginePaymentTypes), paymentType);       
            Logger.Log("Validation done");
            return validateResult;
        }

        public static void PaymentProcessing()
        {
            Logger.Log("Starting processing order files..");
            string paymentJson = File.ReadAllText("PaymentType.json");

            var payment = JsonConvert.DeserializeObject<PaymentAttributes>(paymentJson,
                new StringEnumConverter());


            switch (payment.paymentType)
            {
                case RuleEnginePaymentTypes.PhysicalProduct:
                    Logger.Log("Processing Physical Product Orders");
                    PaymentRuleAction.GeneratePackingSlip();
                    break;

                case RuleEnginePaymentTypes.Book:
                    Logger.Log("Processing Book Orders");
                    PaymentRuleAction.GeneratePackingSlipRoyalDept();
                    break;

                case RuleEnginePaymentTypes.NewMembership:
                    Logger.Log("Processing New membership Orders");
                    PaymentRuleAction.ActivateMembership();
                    break;

                case RuleEnginePaymentTypes.UpgradeMembership:
                    Logger.Log("Processing Upgrade membership Orders");
                    PaymentRuleAction.UpgradeMembership();
                    break;

                case RuleEnginePaymentTypes.Video:
                    Logger.Log("Processing Video Orders");
                    PaymentRuleAction.AddFreeVideo();
                    break;

                default:
                    Logger.Log("Unknown payment type");
                    break;
            }
            Logger.Log("Processing successful.");
        }

      
    }
}
