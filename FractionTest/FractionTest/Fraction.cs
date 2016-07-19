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

        public int GetNumerator()
        {
            return _numerator;
        }

        public int GetDenominator()
        {
            return _denominator;
        }

        public override bool Equals(object obj)
        {
            if (obj.GetType().IsAssignableFrom(typeof(Fraction)))
            {
                Fraction that = (Fraction) obj;
                return _numerator == that._numerator && _denominator == that._denominator;
            }
            return false;
        }

        public override string ToString()
        {
            return String.Format("%d/%d", _numerator, _denominator);
        }
    }
}