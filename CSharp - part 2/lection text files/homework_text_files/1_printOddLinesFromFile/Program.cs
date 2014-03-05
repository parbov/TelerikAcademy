﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _1_printOddLinesFromFile
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader reader = new StreamReader("doc.txt");
            using (reader)
            {
                string content = reader.ReadLine();
                int numOfLine = 0;
                while (content != null)
                {

                    numOfLine++;
                    if (numOfLine % 2 == 1)
                    {
                        Console.WriteLine(content);
                    }
                    content = reader.ReadLine();


                }
            }
        }
    }
}
