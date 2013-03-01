using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12_AsciiTable
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 127;i++ )
            {
                Console.WriteLine((char)i);
            }
        }
    }
}
