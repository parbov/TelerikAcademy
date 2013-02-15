using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _7_fibonacciNMembers
{
    class Program
    {
        static void Main()
        {
            BigInteger sum = 0;
            BigInteger firstNum = 0;
            BigInteger secondNum = 1;
            BigInteger temp = 0;

            Console.WriteLine("Enter int N=");
            int n = int.Parse(Console.ReadLine());

            for (int i = 2; i < n; i++)
            {
                temp = firstNum + secondNum;
                Console.WriteLine(temp);
                sum = sum + temp;
                firstNum = secondNum;
                secondNum = temp;
            }
            Console.WriteLine(sum+1);
        }
    }
}
