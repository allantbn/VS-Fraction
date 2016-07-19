using System;
using System.CodeDom;
using System.ComponentModel;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionTest
{
    [TestClass]
    public class AddFractionsTest
    {
        [TestMethod]
        public void ZeroPlusZero()
        {
            Fraction sum = new Fraction(0).Plus(new Fraction(0));
            Assert.AreEqual(0, sum.IntValue());
        }

        [TestMethod]
        public void NonZeroPlusZero()
        {
            Fraction sum = new Fraction(3).Plus(new Fraction(0));
            Assert.AreEqual(3, sum.IntValue()); 
        }

        [TestMethod]
        public void ZeroPlusNonZero()
        {
            Fraction sum = new Fraction(0).Plus(new Fraction(5));
            Assert.AreEqual(5, sum.IntValue());
        }
    }
}
