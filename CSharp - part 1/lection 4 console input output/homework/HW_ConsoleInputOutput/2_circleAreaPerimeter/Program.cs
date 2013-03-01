using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_circleAreaPerimeter
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter radius:");
            double radius = float.Parse(Console.ReadLine());
            if (radius > 0)
            {
                double area = Math.PI * radius * radius;
                double perimeter =  Math.PI * radius * 2;
                Console.WriteLine("The perimeter is: {0}",perimeter);
                Console.WriteLine("The area is: {0}", area);
            }
            else Console.WriteLine("Incorrect value!");
        }
    }
}
