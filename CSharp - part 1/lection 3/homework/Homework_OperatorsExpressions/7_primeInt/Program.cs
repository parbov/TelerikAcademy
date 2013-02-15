using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_primeInt
{
    class Program
    {
        static void Main()
        {
            int n=170;
            while (n > 100)
            {
                Console.WriteLine("Enter positive int <=100");
                n = int.Parse(Console.ReadLine());
            }
            if ((n % 2 != 0) && (n % 3 != 0) && (n % 5 != 0) && (n % 7 != 0))
            {
                Console.WriteLine("{0} is prime",n);
            }
            else
                Console.WriteLine("{0} is not prime");
        }
    }
}
