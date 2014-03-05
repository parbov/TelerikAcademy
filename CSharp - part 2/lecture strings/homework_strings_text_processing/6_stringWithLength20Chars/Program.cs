using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_stringWithLength20Chars
{
    class Program
    {
        static void Main()
        {
            Console.Write("Please enter string with no more than 20 characters!");
            string text = Console.ReadLine();

            if (text.Length > 20)
            {
                Console.WriteLine("The string is with more than 20 chars!");
            }
            else
            {
                StringBuilder twentyChars = new StringBuilder();
                twentyChars.Append(text);
                while (twentyChars.Length < 20)
                {
                    twentyChars.Append('*');
                }
                Console.WriteLine("The changed text is:{0}", twentyChars.ToString());
            }
        }
    }
}
