using System;

namespace FractionTest
{
    public class Fraction
    {
        private readonly int _numerator;
        private readonly int _denominator;

        public Fraction (int integerValue) : this(integerValue, 1)
        {
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction Plus(Fraction that)
        {
            return new Fraction(_numerator + that._numerator, _denominator);
        }

        public int IntValue()
        {
            return _numerator;
        }

        internal int GetNumerator()
        {
            return _numerator;
        }

        internal int GetDenominator()
        {
            return _denominator;
        }
    }
}