using System;
using System.Collections.Generic;
using System.Text;

namespace RuleEngine
{
    class PaymentRuleAction
    {
        public static int GeneratePackingSlip()
        {
            /* TODO Logic to generate packaging slip
             Then generate commision payment to the agent*/
            GenerateCommisionPayment();
            throw new NotImplementedException();
        }

        public static int GeneratePackingSlipRoyalDept()
        {
            /* TODO Logic to generate duplicate packaging slip for Royal Dept
             Then generate commision payment to the agent*/
            GenerateCommisionPayment();
            throw new NotImplementedException();
        }

        public static void GenerateCommisionPayment()
        {
            /* TODO Logic to generate Commission payment to the agent */
            throw new NotImplementedException();
        }

        public static int ActivateMembership()
        {
            /* TODO Logic to activate membership
             * Then send email to the owner with the membership ID
            */
            SendEmail();
            throw new NotImplementedException();
        }

        public static bool UpgradeMembership()
        {
            /* TODO Logic to upgrade membership
             * Then send email to the owner with the membership ID
            */
            SendEmail();
            throw new NotImplementedException();
        }

        public static void SendEmail()
        {
            //TODO Logic to sent email to the owner with the membership ID
            throw new NotImplementedException();
        }

        public static void AddFreeVideo()
        {
            //TODO Logic to Add free video to the packaign slip
            throw new NotImplementedException();
        }
    }
}
