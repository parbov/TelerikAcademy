using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_isoscelesTriangle
{
    class Program
    {
        static void Main()
        {
            char symbol = '\u00A9';
            Console.OutputEncoding = Encoding.Unicode;
            Console.WriteLine("Enter lenght of the side of the triangle" );
            int size = int.Parse(Console.ReadLine());
            for (int i = 0; i < size; i++)
            {
                Console.WriteLine();
                for (int j = 0; j <= i;j++ )
                {
                    Console.Write(symbol);
                }
            }
            Console.WriteLine();
        }
    }
}
