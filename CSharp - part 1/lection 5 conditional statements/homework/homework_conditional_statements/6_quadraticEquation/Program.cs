using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_quadraticEquation
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter coefficient a: ");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient b: ");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter coefficient c:");
            double c = double.Parse(Console.ReadLine());
            double discriminant = ((b * b) - (4 * a * c));
            double x1, x2;

            if (a == 0)
            {
                Console.WriteLine("This is not a quadratic equation");
            }
            else
            {
                if (discriminant < 0)
                {
                    Console.WriteLine("No Real Roots");
                }
                else if (discriminant == 0)
                {
                    x1 = ((-b) / (2 * a));
                    Console.WriteLine("One double real root x1={0}",x1);
                }
                else if (discriminant > 0)
                {
                    x1 = ((-b - Math.Sqrt(discriminant)) / (2 * a));
                    x2 = ((-b + Math.Sqrt(discriminant)) / (2 * a));
                    Console.WriteLine("The roots are x1={0} , x2={1}",x1,x2);
                }
            }
         }
    }
}
