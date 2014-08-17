using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using NUnit.Framework;

namespace EulerFibonacci.UnitTests
{
    [TestFixture]
    public class FermatFactorizationTests
    {
        [Test]
        public void FactorsOf5959Are59And101()
        {
            var factors = FermatFactorization.findFactors(5959);

            var firstfactor = factors.Item1;
            var secondfactor = factors.Item2;
            Assert.AreEqual(59, firstfactor);
            Assert.AreEqual(101, secondfactor);
            //CollectionAssert.AreEquivalent(new List<BigInteger> { new BigInteger(59), new BigInteger(101)}, firstfactor);
        }

        [Test]
        public void FactorsOfEvenNumberForBigNReturnZero()
        {
            var factors = FermatFactorization.findFactors(2);

            var firstfactor = factors.Item1;
            var secondfactor = factors.Item2;
            Assert.AreEqual(0, firstfactor);
            Assert.AreEqual(0, secondfactor);
        }
    }
}
