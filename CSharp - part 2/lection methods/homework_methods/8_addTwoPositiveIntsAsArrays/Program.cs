using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _8_addTwoPositiveIntsAsArrays
{
    class Program
    {
        static List<int> AddingArrays(int[] shorter, int[] longer)
        {
            if (shorter.Length > longer.Length)
                {
                int[] temp = shorter;
                shorter = longer;
                longer = temp;
                }
 
           
            List<int> result = new List<int>();
            int tempNum = 0;
            for (int i = 0; i < shorter.Length; i++)
            {
                result.Add((shorter[i] + longer[i] + tempNum) % 10);
                tempNum = (shorter[i] + longer[i] + tempNum) / 10;
            }
 
            for (int i = shorter.Length; i < longer.Length; i++)
            {
                result.Add((longer[i] + tempNum) % 10);
                tempNum = (longer[i] + tempNum) / 10;
            }
 
            if (tempNum > 0)
            {
                result.Add(tempNum);
            }
 
            return result;
        }
        static void Main()
        {
            int[] firstArray = new int[RandomNumbers.Generator.Next(10, 21)];
            int[] secondArray = new int[RandomNumbers.Generator.Next(10, 21)];
           
            for (int i = 0; i < firstArray.Length; i++)
            {
                firstArray[i] = RandomNumbers.Generator.Next(0, 10);
            }
           
            for (int i = 0; i < secondArray.Length; i++)
            {
                secondArray[i] = RandomNumbers.Generator.Next(0, 10);
            }
            // printing the 2 arrays on the console
            Console.WriteLine(string.Join(", ", firstArray));
            Console.WriteLine(string.Join(", ", secondArray));
            List<int> result = AddingArrays(firstArray, secondArray);
            Console.WriteLine(string.Join(", ", result));
 
        }
    }
 
    public static class RandomNumbers
    {
        public static Random Generator = new Random();
    }
    
}
