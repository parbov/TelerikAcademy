using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_greatestCommonDivisor
{
    class Program
    {
    

        static void Main()
        {
            int temp=0, gcd=0;
            Console.WriteLine("enter first int");
            int a = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second int");
            int b = int.Parse(Console.ReadLine());

            if (b == 0)
            {
                gcd = a;
            }
            else if (a == 0)
            {
                gcd = b;
            }
            else if (a < b)
            {
                temp = a;
            }
            else if (a == b)
            {
                temp = a;
            }
            else if (a > b)
            {
                temp = b;
            }
           
                for (int i = 1; i <= temp; i++)
                {
                    if ((a % i == 0) && (b % i == 0))
                    {
                        gcd = i;
                    }
                }
            
            Console.WriteLine(gcd);
           
        }
    }
}
