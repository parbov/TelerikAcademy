using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2_concatenateTwoFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader readerFirstFile = new StreamReader("subs.txt", Encoding.GetEncoding("windows-1251"));
            StreamReader readerSecondFile = new StreamReader("subs2.txt", Encoding.GetEncoding("windows-1251"));
            using (readerFirstFile)    // read and write first file
            {
                StreamWriter writer = new StreamWriter("conc.txt", false, Encoding.GetEncoding("windows-1251"));
                using (writer)
                {
                    string s;
                    while ((s = readerFirstFile.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
                    }

                }

            }
            using (readerSecondFile)   //read and append(true) second file to first file
            {
                StreamWriter writer = new StreamWriter("conc.txt", true, Encoding.GetEncoding("windows-1251"));
                using (writer)
                {
                    string s;
                    while ((s = readerSecondFile.ReadLine()) != null)
                    {
                        writer.WriteLine(s);
                    }

                }

            }
        }
    }
}
