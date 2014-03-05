using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _3_insertLineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader reader = new StreamReader("test.txt"))
            {
                using (StreamWriter writer = new StreamWriter("result.txt"))
                {
                    string line;
                    int lineNumber = 0;
                    while ((line = reader.ReadLine()) != null)
                    {
                        writer.WriteLine(++lineNumber + " " + line);
                    }
                }
            }

            Console.WriteLine("File successfully writen!");
        }
    }
}
