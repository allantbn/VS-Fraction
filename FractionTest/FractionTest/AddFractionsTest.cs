using System;
using System.CodeDom;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionTest
{
    [TestClass]
    public class AddFractionsTest
    {
        [TestMethod]
        public void ZeroPlusZero()
        {
            Assert.AreEqual(new Fraction(0), new Fraction(0).Plus(new Fraction(0)));
        }

        [TestMethod]
        public void NonZeroPlusZero()
        {
            Assert.AreEqual(new Fraction(3), new Fraction(3).Plus(new Fraction(0)));
        }

        [TestMethod]
        public void ZeroPlusNonZero()
        {
            Assert.AreEqual(new Fraction(5), new Fraction(0).Plus(new Fraction(5)));

        }

        [TestMethod]
        public void NonNegativeNonZeroOperands()
        {
            Assert.AreEqual(new Fraction(7), new Fraction(3).Plus(new Fraction(4)));
        }

        [TestMethod]
        public void NegativeInputsAndNegativeOutput()
        {
            Assert.AreEqual(new Fraction(-2), new Fraction(-3).Plus(new Fraction(1)));
        }

        [TestMethod]
        public void NonTrivialButSameDenominator()
        {
            Fraction sum = new Fraction(1,5).Plus(new Fraction(2, 5));
            Assert.AreEqual(new Fraction(3, 5), sum);

        }
    }
}
