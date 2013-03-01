using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_pointInRectangleCircle
{
    class Program
    {
        static void Main()
        {
            int circleRadius = 3;

            Console.WriteLine("Enter coordinate x=");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter coordinate y=");
            int y = int.Parse(Console.ReadLine());

            bool inCircle = (((x - 1) * (x - 1) + (y - 1) * (y - 1)) < (circleRadius*circleRadius));
            bool inRectangle = (((x > (-1)) || (x < 5)) && (y < 1 || y > (-1)));
            Console.WriteLine("The point is in circle {0} and in rectangle {1}",inCircle,inRectangle);
        }
    }
}
