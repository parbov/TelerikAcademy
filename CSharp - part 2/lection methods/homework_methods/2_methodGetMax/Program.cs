using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_methodGetMax
{
    class Program
    {
        public static int GetMax(int a, int b)
        {
            int bigger = 0;
            if (a >= b)
            {
                bigger = a;
            }
            else if (b > a)
            {
                bigger = b;
            }
            return bigger;
        }
        static void Main()
        {
            Console.WriteLine("Enter 3 ints");
            int firstInt = int.Parse(Console.ReadLine());
            int secondInt = int.Parse(Console.ReadLine());
            int thirdInt = int.Parse(Console.ReadLine());
            int biggerOfTwo = 0;
            int biggerofThree = 0;
            biggerOfTwo = GetMax(firstInt, secondInt);
            biggerofThree = GetMax(biggerOfTwo, thirdInt);
            Console.WriteLine("The biggest is {0}",biggerofThree);
        }
    }
}
