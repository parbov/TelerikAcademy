using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _10_NCatalan
{
    class Program
    {
        static void Main()
        {
            BigInteger twoFactorial = 1;
            BigInteger nPlusOneFactorial = 1;
            BigInteger factorial = 1;
            BigInteger NCatalan = 0;

            Console.WriteLine("Enter n=");
            int n = int.Parse(Console.ReadLine());
            if (n < 0)
            {
                Console.WriteLine("Wrong input");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    factorial = factorial * i;
                }
                for (int j = 1; j <= n + 1; j++)
                {
                    nPlusOneFactorial = nPlusOneFactorial * j;
                }
                for (int k = 1; k <= 2 * n; k++)
                {
                    twoFactorial = twoFactorial * k;
                }
                NCatalan = (twoFactorial) / (nPlusOneFactorial * factorial);
                Console.WriteLine(NCatalan);
            }
        }
    }
}

