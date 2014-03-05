using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_tenRandomValues
{
    class Program
    {
        static void Main()
        {
            Random genRan = new Random();
            for (int i = 1; i <= 10; i++)
            {
                int randonNum = genRan.Next(100, 201);
                Console.WriteLine("{0} ", randonNum);
            }
        }
    }
}
