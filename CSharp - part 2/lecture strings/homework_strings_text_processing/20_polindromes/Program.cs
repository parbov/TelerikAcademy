using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _20_polindromes
{
    class Program
    {
        static bool IsPalindrome(string str)
        {
            for (int i = 0; i < str.Length / 2; i++)
                if (str[i] != str[str.Length - 1 - i])
                    return false;

            return true;
        }

        static void Main()
        {
            string str = "Static void Main() ABBA, using System lamal, exe.";

            foreach (Match item in Regex.Matches(str, @"\w+"))
                if (IsPalindrome(item.Value)) Console.WriteLine(item);

            foreach (Match item in Regex.Matches(str, @"\b(?<N>.)+.?(?<-N>\k<N>)+(?(N)(?!))\b")) // http://i.qkme.me/355ovv.jpg
                Console.WriteLine(item);
        }
    }
}
