using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_convertStringToSequenceUnicodeChars
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "Hi!";
            string newString = null;
            for (int i = 0; i < str.Length; i++)
            {
                newString = String.Format("{0}{1}{2}", newString, "\\u", Convert.ToString(((int)str[i]), 16).PadLeft(4, '0'));
            }
            Console.WriteLine(newString);
        }
    }
}
