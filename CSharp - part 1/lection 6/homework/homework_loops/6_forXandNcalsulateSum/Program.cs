using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _6_forXandNcalsulateSum
{
    class Program
    {
        static void Main()
        {
            double sum = 1;
            double midFactorial = 1;
            Console.WriteLine("Enter x=");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N=");
            int n = int.Parse(Console.ReadLine());

            if ((x <= 0) || (n <= 0))
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = 1; j <= i; j++)
                    {
                        midFactorial = midFactorial * j;
                    }
                    sum=((sum)+(midFactorial/(Math.Pow(x,i))));
                    midFactorial = 1;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
