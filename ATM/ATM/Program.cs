using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Amount");
            string amount = Console.ReadLine();
            double a = double.Parse(amount);
                double b = a % 100;
                double c = a - b;
                double d = c / 100;
            Console.WriteLine("A hundred");
            for (var i = 0; i < d; i++)
            {
            Console.WriteLine(100);
            }


            double h = b % 50;
            double e = b - h;
            Console.WriteLine("Fifty");
            Console.WriteLine(e);

            double f = h % 20;
            double g = h - f;
            double t = g / 20;
            Console.WriteLine("Twenty");
            for (var i = 0; i < t; i++)
            {
                Console.WriteLine(20);
            }

            double q = f % 10;
            double w = f - q;
            Console.WriteLine("Ten");
            Console.WriteLine(w);

            double r = q % 5;
            double y = q - r;
            Console.WriteLine("Five");
            Console.WriteLine(y);

            Console.WriteLine("One");
            for(var i = 0; i < r; i++)
            {
                Console.WriteLine(1);
            }
        }
    }
}
