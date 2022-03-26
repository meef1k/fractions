using System;
namespace fraction
{
    class Fraction : IComparable<Fraction>
    {
        public readonly int numerator;
        public readonly int denominator;
        public Fraction(int numerator, int denominator)
        {
            if (denominator == 0)
            {
                throw new ArgumentException("Wrong denominator!");   
            }
            this.numerator = numerator;
            this.denominator = denominator;
        }
        public override string ToString()
        {
            return $"{numerator}/{denominator}";
        }

        public int CompareTo(Fraction f2)
        {
            int numerator1 = numerator * f2.denominator;
            int numerator2 = f2.numerator * denominator;
            if(numerator1 > numerator2)
            {
                return 1;
            }
            else if(numerator1 < numerator2)
            {
                return -1;
            }
            return 0;
        }

        public static Fraction operator +(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.numerator * f2.denominator + f2.numerator * f1.denominator, f1.denominator * f2.denominator);
        }
        public static Fraction operator -(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.numerator * f2.denominator - f2.numerator * f1.denominator, f1.denominator * f2.denominator);
        }
        public static Fraction operator *(Fraction f1, Fraction f2)
        {
            return new Fraction(f1.numerator * f2.numerator, f1.denominator * f2.denominator);
        }
        public static Fraction operator /(Fraction f1, Fraction f2)
        {
            if (f1.numerator == 0 || f2.numerator == 0)
            {
                throw new ArgumentException("Wrong denominator!");
            }
            return new Fraction(f1.numerator * f2.denominator, f1.denominator * f2.numerator);
        }
    }
}
