using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_trapezoidArea
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("enter side a=");
            float a = float.Parse(Console.ReadLine());
            Console.WriteLine("enter side b=");
            float b = float.Parse(Console.ReadLine());
            Console.WriteLine("Enter height h=");
            float h = float.Parse(Console.ReadLine());

            float area = (((a+b)*h)/2);
            Console.WriteLine("the area is {0}",area);
        }
    }
}
