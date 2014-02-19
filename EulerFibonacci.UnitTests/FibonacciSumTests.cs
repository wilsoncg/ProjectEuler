using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using NUnit.Framework;

namespace EulerFibonacci.UnitTests
{
    [TestFixture]
    public class FibonacciSumTests
    {
        [Test]
        public void FirstFibonacciNumberisZero()
        {
            var fib = FibonnaciSum.fibToN(1);

            Assert.AreEqual(0, fib);
        }

        [Test]
        public void SecondFibonacciNumberisOne()
        {
            var fib = FibonnaciSum.fibToN(2);

            Assert.AreEqual(1, fib);
        }

        [Test]
        public void ThirdFibonacciNumberIsOne()
        {
            var fib = FibonnaciSum.fibToN(3);

            Assert.AreEqual(1, fib);
        }

        [Test]
        public void FourthFibonacciNumberIsTwo()
        {
            var fib = FibonnaciSum.fibToN(4);

            Assert.AreEqual(2, fib);
        }

        [Test]
        public void FifthFibonacciNumberIsThree()
        {
            var fib = FibonnaciSum.fibToN(5);

            Assert.AreEqual(3, fib);
        }

        [Test]
        public void SixthFibonacciNumberIsFive()
        {
            var fib = FibonnaciSum.fibToN(6);

            Assert.AreEqual(5, fib);
        }

        [Test]
        public void FibonacciListForFirstSixNumbersIsCorrect()
        {
            var fibList = FibonnaciSum.fibList(6).ToList();

            Assert.AreEqual(new BigInteger(0), fibList[0]);
            Assert.AreEqual(new BigInteger(1), fibList[1]);
            Assert.AreEqual(new BigInteger(1), fibList[2]);
            Assert.AreEqual(new BigInteger(2), fibList[3]);
            Assert.AreEqual(new BigInteger(3), fibList[4]);
            Assert.AreEqual(new BigInteger(5), fibList[5]);
        }

        [Test]
        public void SumOfFirstFibonnaciNumberIsZero()
        {
            var sum = FibonnaciSum.sumFibToN(1);

            Assert.AreEqual(new BigInteger(0), sum);
        }

        [Test]
        public void SumOfFirstTwoFibonnaciNumbersIsOne()
        {
            var sum = FibonnaciSum.sumFibToN(2);

            Assert.AreEqual(new BigInteger(1), sum);
        }

        [Test]
        public void SumOfFirstThreeFibonacciNumbersIsTwo()
        {
            var sum = FibonnaciSum.sumFibToN(3);

            Assert.AreEqual(new BigInteger(2), sum);
        }

        [Test]
        public void SumOfFirstFourFibonacciNumbersIsFour()
        {
            var sum = FibonnaciSum.sumFibToN(4);

            Assert.AreEqual(new BigInteger(4), sum);
        }

        [Test]
        public void SumOfFirstFiveFibonacciNumbersIsSeven()
        {
            var sum = FibonnaciSum.sumFibToN(5);

            Assert.AreEqual(new BigInteger(7), sum);
        }

        [Test]
        public void FibonacciListForFirstFiveEvenTermsIsCorrect()
        {
            var fibList = FibonnaciSum.evenTermsFibList(10).ToList();

            Assert.AreEqual(new BigInteger(0), fibList[0]);
            Assert.AreEqual(new BigInteger(2), fibList[1]);
            Assert.AreEqual(new BigInteger(8), fibList[2]);
            Assert.AreEqual(new BigInteger(34), fibList[3]);
            Assert.AreEqual(new BigInteger(144), fibList[4]);
        }
    }
}
