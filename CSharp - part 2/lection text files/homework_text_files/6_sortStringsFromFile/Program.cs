using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _6_sortStringsFromFile
{
    class Program
    {
        static List<string> ReadLines()
        {
            List<string> lines = new List<string>();

            using (StreamReader input = new StreamReader("input.txt"))
                for (string line; (line = input.ReadLine()) != null; )
                    lines.Add(line);

            return lines;
        }

        static void WriteLines(List<string> lines)
        {
            using (StreamWriter output = new StreamWriter("output.txt"))
                foreach (string line in lines)
                    output.WriteLine(line);
        }

        static void Main()
        {
            List<string> lines = ReadLines(); // File.ReadAllLines

            lines.Sort();

            WriteLines(lines); // File.WriteAllLines
        }
    }
}
