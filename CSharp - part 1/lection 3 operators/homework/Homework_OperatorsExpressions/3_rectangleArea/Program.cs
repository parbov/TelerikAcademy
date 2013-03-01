using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_rectangleArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Enter width");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter heigh");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Rectangle area: {0}",a*b);
        }
    }
}
