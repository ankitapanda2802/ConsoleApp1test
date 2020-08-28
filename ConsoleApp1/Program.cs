using System;

namespace RuleEngineSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!; successful checkin to github; testing");
            RuleEngine.RuleEngine.ValidatePaymentType(1);
        }
    }
}
