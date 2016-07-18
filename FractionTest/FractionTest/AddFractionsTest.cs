using System;
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
    }
}
