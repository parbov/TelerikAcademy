using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _5_exercise
{
    class Program
    {
        static void Main()
        {
            BigInteger factorialN=1;
            BigInteger factorialK=1;
            BigInteger factorialKminusN=1;
            BigInteger result;
            Console.WriteLine("Enter N and K ( 1<N<K )");
            int n = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());
            if ((n >= k) || (n < 0) || (k < 0))
            {
                Console.WriteLine("Wrong input!");
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    factorialN = factorialN * i;
                }
                for (int j = 1; j <= k; j++)
                {
                    factorialK = factorialK * j;
                }
                for (int z = 1; z <= (k-n); z++)
                {
                    factorialKminusN = factorialKminusN * z;
                }
                result = (factorialN * factorialK) / factorialKminusN;
                Console.WriteLine(result);
            }

        }
    }
}
