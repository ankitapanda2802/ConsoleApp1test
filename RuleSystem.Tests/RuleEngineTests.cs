using NUnit.Framework;
using System;

namespace RuleSystem.Tests
{
    [TestFixture]
    public class RuleEngineTests
    {
        [Test]
        public void SampleTest()
        {
            Assert.Pass();
        }

        [Test]
        public void ReturnCorrectPaymentTypes([Values(0,1,2,3,4)] int input)
        {
            bool output = RuleEngine.RuleEngine.ValidatePaymentType(input);
            Assert.AreEqual(true, output);
        }

    }
}
