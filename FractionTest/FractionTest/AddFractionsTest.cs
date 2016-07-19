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
            Assert.AreEqual(0, new Fraction(0).Plus(new Fraction(0)).IntValue());
        }

        [TestMethod]
        public void NonZeroPlusZero()
        {
            Assert.AreEqual(3, new Fraction(3).Plus(new Fraction(0)).IntValue()); 
        }

        [TestMethod]
        public void ZeroPlusNonZero()
        {
            Assert.AreEqual(5, new Fraction(0).Plus(new Fraction(5)).IntValue());
        }

        [TestMethod]
        public void NonNegativeNonZeroOperands()
        {
            Assert.AreEqual(7, new Fraction(3).Plus(new Fraction(4)).IntValue());
        }

        [TestMethod]
        public void NegativeInputsAndNegativeOutput()
        {
            Assert.AreEqual(-2, new Fraction(-3).Plus(new Fraction(1)).IntValue());
        }

        [TestMethod]
        public void NonTrivialButSameDenominator()
        {
            Fraction sum = new Fraction(1,5).Plus(new Fraction(2, 5));
            Assert.AreEqual(3, sum.GetNumerator());
            Assert.AreEqual(5, sum.GetDenominator());
        }
    }
}
