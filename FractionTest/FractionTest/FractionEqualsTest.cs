using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FractionTest
{
    [TestClass]
    public class FractionEqualsTest
    {
        [TestMethod]
        public void SameNumeratorAndDenominator()
        {
            Assert.AreEqual(new Fraction(3, 5), new Fraction(3,5));
        }

        [TestMethod]
        public void DifferentNumerators()
        {
            Assert.AreNotEqual(new Fraction(1, 5), new Fraction(2, 5));
        }

        [TestMethod]
        public void DIfferentDenominators()
        {
            Assert.AreNotEqual(new Fraction(3, 4), new Fraction(3, 7));
        }

        [TestMethod]
        public void WholeNumberEqualsSameFraction()
        {
            Assert.AreEqual(new Fraction(5, 1), new Fraction(5));
        }

        [TestMethod]
        public void WholeNumberNotEqualToDifferentWholeNumber()
        {
            Assert.AreNotEqual(new Fraction(5), new Fraction(6));
        }
    }
}
