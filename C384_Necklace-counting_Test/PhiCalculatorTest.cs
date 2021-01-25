using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Numerics;
using C384_Necklace_counting.Math;
using C384_Necklace_counting.Necklace;

namespace C384_Necklace_counting_Test
{
    [TestClass]
    public class PhiCalculatorTest
    {
        [TestMethod]
        public void GetPrimesTest()
        {
            List<ulong> primes = PhiCalculator.GetPrimes(12);

            List<ulong> expectedPrimes = new List<ulong>();
            expectedPrimes.Add(2);
            expectedPrimes.Add(3);
            expectedPrimes.Add(5);
            expectedPrimes.Add(7);
            expectedPrimes.Add(11);

            Assert.AreEqual(expectedPrimes.Count, primes.Count);
            for(int i = 0; i < expectedPrimes.Count; i++)
            {
                Assert.AreEqual(expectedPrimes[i], primes[i]);
            }
        }

        [TestMethod]
        public void PhiTest()
        {
            ulong returnValue = PhiCalculator.Phi(12);
            ulong expectedReturnValue = 4;
            Assert.AreEqual(expectedReturnValue, returnValue);
            Assert.AreEqual((ulong)1, PhiCalculator.Phi(1));
            Assert.AreEqual((ulong)6, PhiCalculator.Phi(7));
        }
    }
}
