using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_printFileContent
{
    class Program
    {
        static void Main()
        {
            Console.Write("Enter file name:");
            try
            {
                Console.WriteLine(System.IO.File.ReadAllText(Console.ReadLine()));
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception cought!\n{0}:{1}", e.GetType().Name, e.Message);
            }
        }
    }
}
