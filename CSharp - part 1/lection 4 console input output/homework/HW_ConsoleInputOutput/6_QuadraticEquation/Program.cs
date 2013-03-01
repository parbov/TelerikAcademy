using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_QuadraticEquation
{
    class Program
    {
        static void Main()
        {
            double desc;
            double x1, x2;
            Console.WriteLine("Enter value of parameter a:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("enter value of parameter b:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter value of parameter c:");
            double c = double.Parse(Console.ReadLine());
            desc = (b * b) - (4 * a * c);

            if (a == 0)
            {
                Console.WriteLine("This is not a quadratic equation");
            }
            else
            {
                if (desc < 0)
                {
                    Console.WriteLine("No real roots");
                }
                else
                {
                    if (desc == 0)
                    {
                        x1 = (-b) / (2 * a);
                        Console.WriteLine("The equation has one double root {0}", x1);
                    }
                    else
                    {
                        x1 = (-b + Math.Sqrt(desc)) / 2 * a;
                        x2 = (-b - Math.Sqrt(desc)) / 2 *a;
                        Console.WriteLine("Root \"x1\" is : {0}", x1);
                        Console.WriteLine("Root \"x2\" is : {0}", x2);
                    }
                }
            }
        }
    }
}
