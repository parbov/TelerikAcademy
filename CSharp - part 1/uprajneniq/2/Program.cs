using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i <= n / 2; i++)
            {
                string dots = new string('.', i);
                string stars = new string('*', n - 2 * i);
                Console.WriteLine("{0}{1}{2}", dots, stars, dots);
            }

            for (int i = n / 2 - 1; i >= 0; i--)
            {
                string dots = new string('.', i);
                string stars = new string('*', n - 2 * i);
                Console.WriteLine("{0}{1}{2}", dots, stars, dots);
            }
        }
    }
}
