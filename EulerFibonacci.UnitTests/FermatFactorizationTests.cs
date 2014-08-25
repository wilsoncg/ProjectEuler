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

            var firstfactor = factors.ElementAt(0);
            var secondfactor = factors.ElementAt(1);
            Assert.AreEqual(59, firstfactor);
            Assert.AreEqual(101, secondfactor);
        }

        [Test]
        public void FactorsOf13195Are5And7And13And29()
        {
            var factors = FermatFactorization.findFactors(13195);

            Assert.AreEqual(4, factors.Count());
            var firstFactor = factors.ElementAt(0);
            var secondFactor = factors.ElementAt(1);
            var thirdFactor = factors.ElementAt(2);
            var fourthFactor = factors.ElementAt(3);
            Assert.AreEqual(5, firstFactor);
            Assert.AreEqual(7, secondFactor);
            Assert.AreEqual(13, thirdFactor);
            Assert.AreEqual(29, fourthFactor);
        }

        [Test]
        public void FactorsOf17Are1And17()
        {
            var factors = FermatFactorization.findFactors(17);

            var firstfactor = factors.ElementAt(0);
            var secondfactor = factors.ElementAt(1);
            Assert.AreEqual(1, firstfactor);
            Assert.AreEqual(17, secondfactor);
        }

        [Test]
        public void FactorsOfEvenNumberForBigNReturnZero()
        {
            var factors = FermatFactorization.findFactors(2);

            CollectionAssert.IsEmpty(factors);
        }
    }
}
