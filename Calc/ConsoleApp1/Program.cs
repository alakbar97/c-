using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write Number");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter Operator");
            var o = Console.ReadLine();
            
            while (true)
            {
                switch (o) {
                    case "+":
                  Console.WriteLine("Enter Number");
                  double b = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Operator");
                        var op = Console.ReadLine();
                        Console.WriteLine("Result");
                        Console.WriteLine(a + b);
                        a = a + b;
                        
                        if (op == "-")
                        {
                            Console.WriteLine("Enter num");
                         double c = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a - c);
                            a = a - c;
                        }
                        if (op == "*")
                        {
                            Console.WriteLine("Enter num");
                            double d = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a * d);
                            a = a * d;
                        }
                        if (op == "/")
                        {
                            Console.WriteLine("Enter num");
                            double e = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a / e);
                            a = a / e;
                        }
                        break;

                    case "-":
                        Console.WriteLine("Enter Number");
                        double f = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Operator");
                        var opp = Console.ReadLine();
                        Console.WriteLine("Result");
                        Console.WriteLine(a - f);
                        a = a - f;

                        if (opp == "+")
                        {
                            Console.WriteLine("Enter num");
                            double c = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a + c);
                            a = a + c;
                        }
                        if (opp == "*")
                        {
                            Console.WriteLine("Enter num");
                            double d = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a * d);
                            a = a * d;
                        }
                        if (opp == "/")
                        {
                            Console.WriteLine("Enter num");
                            double e = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a / e);
                            a = a / e;
                        }
                        break;
                    case "*":
                        Console.WriteLine("Enter Number");
                        double g = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Operator");
                        var ope = Console.ReadLine();
                        Console.WriteLine("Result");
                        Console.WriteLine(a * g);
                        a = a * g;

                        if (ope == "-")
                        {
                            Console.WriteLine("Enter num");
                            double c = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a - c);
                            a = a - c;
                        }
                        if (ope == "+")
                        {
                            Console.WriteLine("Enter num");
                            double d = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a + d);
                            a = a + d;
                        }
                        if (ope == "/")
                        {
                            Console.WriteLine("Enter num");
                            double e = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a / e);
                            a = a / e;
                        }
                        break;

                    case "/":
                        Console.WriteLine("Enter Number");
                        double h = double.Parse(Console.ReadLine());
                        Console.WriteLine("Enter Operator");
                        var oper = Console.ReadLine();
                        Console.WriteLine("Result");
                        Console.WriteLine(a / h);
                        a = a / h;

                        if (oper == "-")
                        {
                            Console.WriteLine("Enter num");
                            double c = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a - c);
                            a = a - c;
                        }
                        if (oper == "*")
                        {
                            Console.WriteLine("Enter num");
                            double d = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a * d);
                            a = a * d;
                        }
                        if (oper == "+")
                        {
                            Console.WriteLine("Enter num");
                            double e = double.Parse(Console.ReadLine());
                            Console.WriteLine("Result");
                            Console.WriteLine(a + e);
                            a = a + e;
                        }
                        break;

                }
            }
        }
    }
}
