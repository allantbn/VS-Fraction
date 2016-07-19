using System;

namespace FractionTest
{
    public class Fraction
    {
        private int _integerValue;
        private int v;

        public Fraction (int integerValue)
        {
            _integerValue = integerValue;
        }

        public Fraction(int numerator, int denominator)
        {
            _integerValue = numerator;
        }

        public Fraction Plus(Fraction fraction)
        {
            return new Fraction(_integerValue + fraction._integerValue);
        }

        public int IntValue()
        {
            return _integerValue;
        }

        internal int GetNumerator()
        {
            return 3;
        }

        internal int GetDenominator()
        {
            return 5;
        }
    }
}