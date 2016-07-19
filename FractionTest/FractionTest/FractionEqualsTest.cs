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
    }
}
