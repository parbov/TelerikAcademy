using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _24_listInAlphabeticalOrder
{
    class Program
    {
        static void Main()
        {
            string[] inWords = Console.ReadLine().Split();

            var sortedWords = inWords.OrderBy(x => x); //.ThenBy(x => x.Length);
            foreach (var item in sortedWords)
            {
                Console.Write("{0} ", item);
            }
        }
    }
}
