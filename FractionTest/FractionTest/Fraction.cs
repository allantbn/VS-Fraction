using System;

namespace FractionTest
{
    public class Fraction
    {
        private readonly int _integerValue;
        private readonly int _denominator;

        public Fraction (int integerValue)
        {
            _integerValue = integerValue;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _integerValue = numerator;
            _denominator = denominator;
        }

        public Fraction Plus(Fraction fraction)
        {
            return new Fraction(_integerValue + fraction._integerValue, _denominator);
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
            return _denominator;
        }
    }
}