using System;

namespace FractionTest
{
    public class Fraction
    {
        private int _integerValue;

        public Fraction (int integerValue)
        {
            _integerValue = integerValue;
        }

        public Fraction Plus(Fraction fraction)
        {
            return new Fraction(_integerValue + fraction._integerValue);
        }

        public int IntValue()
        {
            return _integerValue;
        }
    }
}