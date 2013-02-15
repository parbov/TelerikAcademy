using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _4_NfactDividedKfact
{
    class Program
    {
        static void Main()
        { 
            BigInteger product = 1;
            Console.WriteLine("1<K<N");
            Console.WriteLine("Enter K for K factoriel");
            int k = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter N for N factoriel");
            int n = int.Parse(Console.ReadLine());

            if ((k >= n)||(k<1)||(n<1))
            {
                Console.WriteLine("Wrong input!");
            }
            else
            {
              
                for (int i = k+1; i <= n; i++)
                {
                    product = product * i;
                }
            }
            Console.WriteLine("N!/K! = {0}",product);
        }
    }
}
