using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_threeInts
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter first Int:");
            int firstInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second Int:");
            int secInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter third int:");
            int thirdInt = int.Parse(Console.ReadLine());
            Console.WriteLine("Their sum is: {0}",firstInt+secInt+thirdInt);
        }
    }
}
