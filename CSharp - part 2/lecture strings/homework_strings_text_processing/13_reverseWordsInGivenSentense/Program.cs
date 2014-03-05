﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace _13_reverseWordsInGivenSentense
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "C#   is not C++, not PHP and not Delphi!  Test 1, 2,3";

            string regex = @"\s+|,\s*|\.\s*|!\s*|$";

            var words = new Stack<string>();

            foreach (var word in Regex.Split(str, regex))
                if (!String.IsNullOrEmpty(word)) words.Push(word);

            foreach (var separator in Regex.Matches(str, regex))
                Console.Write(words.Pop() + separator);

            Console.WriteLine();
        }
    }
}
