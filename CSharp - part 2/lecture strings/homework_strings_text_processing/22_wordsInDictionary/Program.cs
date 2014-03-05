using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22_wordsInDictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            string[] allWordsArr = text.Split(new char[] { ' ', '.', ',' }, StringSplitOptions.RemoveEmptyEntries);

            Dictionary<string, int> rechnik = new Dictionary<string, int>();

            foreach (var word in allWordsArr)
            {
                if (rechnik.ContainsKey(word))
                {
                    rechnik[word] = rechnik[word] + 1;
                }
                else 
                {
                    rechnik.Add(word, 1);
                }
            }

            foreach (var word in rechnik)
            {
                Console.WriteLine("{0,-15} - {1} times", word.Key, word.Value);
            }
        }
    }
}
