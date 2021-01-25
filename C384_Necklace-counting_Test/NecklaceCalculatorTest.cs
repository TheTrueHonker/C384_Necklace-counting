using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Numerics;
using C384_Necklace_counting.Math;
using C384_Necklace_counting.Necklace;

namespace C384_Necklace_counting_Test
{
    [TestClass]
    public class NecklaceCalculatorTest
    {
        [TestMethod]
        public void NecklacesTest()
        {
            BigInteger returnValue = NecklaceCalculator.Necklaces(3, 7);
            BigInteger expectedReturnValue = 315;
            Assert.AreEqual(expectedReturnValue, returnValue);
        }

        [TestMethod]
        public void GetProductsTest()
        {
            Dictionary<ulong, ulong> returnValues = NecklaceCalculator.GetProducts(7);
            Dictionary<ulong, ulong> expectedReturnValues = new Dictionary<ulong, ulong>();
            expectedReturnValues.Add(1, 7);
            expectedReturnValues.Add(7, 1);
            Assert.AreEqual(expectedReturnValues.Count, returnValues.Count);
            Assert.AreEqual(expectedReturnValues[1], returnValues[1]);
            Assert.AreEqual(expectedReturnValues[7], returnValues[7]);
        }
    }
}
