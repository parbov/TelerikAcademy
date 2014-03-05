using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _4_compareFilesLineByLine
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader readerOne = new StreamReader("textfile1.txt"), readerTwo = new StreamReader("textfile2.txt"))
            {
                string lineFirstFile, lineSecondFile;
                int differentLines = 0, equalLines = 0;

                while ((lineFirstFile = readerOne.ReadLine()) != null && (lineSecondFile = readerTwo.ReadLine()) != null)
                {
                    if (lineFirstFile == lineSecondFile) equalLines++;
                    else differentLines++;
                }

                Console.WriteLine("{0} diff. lines / {1} same lines of total {2}", differentLines, equalLines,
                    (differentLines + equalLines));
            }      
        }
    }
}
