using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _13_trailingZeros
{
    class Program
    {
        static void Main()
        {
            int temp = 0;
            int counter = 0;
            Console.WriteLine("Enter number N=");
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)
            {
                temp = i;
                while (temp % 5 == 0)
                {
                    counter++;
                    temp = temp / 5;
                }
            }
            Console.WriteLine(counter);

        }
    }
}
