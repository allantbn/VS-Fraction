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
            if (fraction._integerValue != 0) 
                return fraction;
            else
                return this;
        }

        public int IntValue()
        {
            return _integerValue;
        }
    }
}