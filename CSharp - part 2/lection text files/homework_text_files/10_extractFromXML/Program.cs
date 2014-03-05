using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10_extractFromXML
{
    class Program
    {
        static void Main(string[] args)
        {
            using (StreamReader input = new StreamReader("input.txt"))
            {
                for (int i; (i = input.Read()) != -1; ) // Read char by char
                {
                    if (i == '>') // Inside text node
                    {
                        string text = String.Empty;

                        while ((i = input.Read()) != -1 && i != '<') text += (char)i;

                        if (!String.IsNullOrWhiteSpace(text)) Console.WriteLine(text.Trim());
                    }
                }
            }
        }
    }
}
