﻿using System;

namespace FractionTest
{
    public class Fraction
    {
        private readonly int _denominator;
        private readonly int _numerator;

        public Fraction (int integerValue)
        {
            _numerator = integerValue;
            _denominator = 1;
        }

        public Fraction(int numerator, int denominator)
        {
            _numerator = numerator;
            _denominator = denominator;
        }

        public Fraction Plus(Fraction fraction)
        {
            return new Fraction(_numerator + fraction._numerator, _denominator);
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