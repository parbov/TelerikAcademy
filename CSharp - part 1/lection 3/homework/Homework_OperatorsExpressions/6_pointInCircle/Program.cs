using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_pointInCircle
{
    class Program
    {
        static void Main()
        {
            int circleRadius = 5;

            Console.WriteLine("Enter coordinate x= ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter coordinate y= ");
            int y = int.Parse(Console.ReadLine());
            bool inCircle = (((x * x) + (y * y)) <= (circleRadius * circleRadius));
            Console.WriteLine("The point is in the circle: {0}",inCircle);
        }
    }
}
