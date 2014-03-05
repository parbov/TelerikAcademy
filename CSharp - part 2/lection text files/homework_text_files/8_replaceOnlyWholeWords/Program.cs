﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace _8_replaceOnlyWholeWords
{
    class Program
    {
        static void Main()
        {
            string[] words = { "bla", " ", "\r\n", "start", " start " };

            string fileName = "testFile.txt";
            string resultFileName = "resultFile.txt";
            Random randomGenerator = new Random();

            StreamWriter writer = new StreamWriter(fileName, false, Encoding.GetEncoding("windows-1251"));
            using (writer)
            {
                for (int i = 0; i < 100; i++)
                {
                    writer.Write(words[randomGenerator.Next(words.Length)]);
                }
            }

            writer = new StreamWriter(resultFileName, false, Encoding.GetEncoding("windows-1251"));
            StreamReader reader = new StreamReader(fileName, Encoding.GetEncoding("windows-1251"));

            string line;
            using (writer)
            {
                using (reader)
                {
                    line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.WriteLine(Regex.Replace(line, @"(\W|^)start(\W|$)", "$1finish$2"));
                        line = reader.ReadLine();
                    }
                }
            }

            Process openFile = new Process();
            openFile.StartInfo.FileName = fileName;
            openFile.Start();

            openFile.StartInfo.FileName = resultFileName;
            openFile.Start();
        }
    }
}
