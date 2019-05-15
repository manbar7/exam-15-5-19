using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp25
{
    class Rational
    {
        public int Numerator { get;private set; }
        public int Denominator { get; private set; }

        public Rational(int numerator, int denominator)
        {
            this.Numerator = numerator;
            this.Denominator = denominator;
        }

        public bool GreaterThan(Rational R)
        {
            return this.Numerator * R.Denominator > this.Denominator * R.Numerator;
        }

        public static Rational operator +(Rational r1,Rational r2)
        {
            return new Rational (r1.Numerator * r2.Denominator + r1.Denominator * r2.Numerator,r1.Denominator * r2.Denominator); 
        }

        public static Rational operator -(Rational r1, Rational r2)
        {
            return new Rational (r1.Numerator * r2.Denominator - r1.Denominator * r2.Numerator,r1.Denominator * r2.Denominator);
        }

        public static Rational operator *(Rational r1, Rational r2)
        {
            return new Rational(r1.Numerator * r2.Numerator,r1.Denominator * r2.Denominator);
        }

        public int GetNumerator(Rational r1)
        {
            return this.Numerator;
        }

        public int GetDenominator(Rational r1)
        {
            return this.Denominator;
        }

        public override string ToString()
        {
            return $"The formal view for the Rational number:{this.Numerator}/{this.Denominator}";
        }
    }

}
