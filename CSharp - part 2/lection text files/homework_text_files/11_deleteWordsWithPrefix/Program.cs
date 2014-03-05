using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace _11_deleteWordsWithPrefix
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader read = new StreamReader("test.txt");
            StreamWriter write = new StreamWriter("output.txt");
            string line = "";

            using (read)
            {
                using (write)
                {
                    line = read.ReadLine();
                    while (line != null)
                    {
                        line = line.ToLower();
                        line = Regex.Replace(line, @"\btest\w*(\s|\S)\b", "");
                        write.WriteLine(line);
                        line = read.ReadLine();
                    }
                }
            }
        }
    }
}
