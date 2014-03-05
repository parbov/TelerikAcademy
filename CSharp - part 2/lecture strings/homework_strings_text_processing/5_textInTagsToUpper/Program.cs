using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_textInTagsToUpper
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = @"We are living in a <upcase>yellow submarine</upcase>. We don't have <upcase>anything</upcase> else.";
            //string str = Console.ReadLine();
            int startIndex = 0;
            int endIndex = 0;
            Console.WriteLine(str);

            for (int i = 0; i < str.Length - 8; i++)
            {
                if (str.Substring(i, 8) == "<upcase>")
                {
                    startIndex = i + 8;
                    i = startIndex;
                }
                if (str.Substring(i, 9) == "</upcase>")
                {
                    endIndex = i;
                    int length = endIndex - startIndex;
                    string upperStr = str.Substring(startIndex, length).ToUpper();
                    //Console.WriteLine(upperStr);
                    str = str.Remove(startIndex, length);
                    //Console.WriteLine(str);
                    str = str.Insert(startIndex, upperStr);
                    //Console.WriteLine(str);
                    str = str.Remove(startIndex - 8, 8);
                    str = str.Remove(endIndex - 8, 9);
                }
            }
            Console.WriteLine(str);
        }
    }
}
