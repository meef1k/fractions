using System;
using System.Collections.Generic;

namespace fraction
{
    class Program
    {
        static void Main(string[] args)
        {
            Fraction f1 = new Fraction(1, 3);
            Fraction f2 = new Fraction(1, 2);
            Console.WriteLine(f1);
            Console.WriteLine(f2);
            Console.WriteLine(f1 + f2);
            Console.WriteLine(f1 - f2);
            Console.WriteLine(f1 * f2);
            Console.WriteLine(f1 / f2);

            List<Fraction> list = new List<Fraction>();
            list.Add(f1);
            list.Add(f2);
            list.Add(new Fraction(4, 5));
            list.Add(new Fraction(7, 3));
            list.Sort();
            list.ForEach(Console.WriteLine);
        }
    }
}
