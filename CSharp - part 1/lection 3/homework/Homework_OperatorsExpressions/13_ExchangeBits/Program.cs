using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13_ExchangeBits
{
    class Program
    {

        static void Main()
        {
            uint mask =1;
            uint numberAndMask;

            Console.WriteLine("Enter unsigned int");
            uint number = uint.Parse(Console.ReadLine());
            string oldStr = Convert.ToString(number, 2).PadLeft(32,'0');
            Console.WriteLine(oldStr);

            uint bitThree = (number & (1 << 3)) >> 3;
            uint bitFour = (number & (1 << 4)) >> 4;
            uint bitFive = (number & (1 << 5)) >> 5;
            uint bitTwentyFour = (number & (1 << 24)) >> 24;
            uint bitTwentyFive = (number & (1 << 25)) >> 25;
            uint bitTwentySix = (number & (1 << 26)) >> 26;

            if (bitThree != bitTwentyFour)
            {
                if (bitThree == 0)
                {
                    mask = ~(mask << 24);
                    numberAndMask = (number & mask);
                    number = numberAndMask;
                }
                else
                {
                    mask = mask << 24;
                    numberAndMask = (number | mask);
                    number = numberAndMask;
                }
            }

            if (bitFour != bitTwentyFive)
            {
                if (bitFour == 0)
                {
                    mask = 1;
                    mask = ~(mask << 25);
                    numberAndMask = (number & mask);
                    number = numberAndMask;
                }
                else
                {
                    mask = 1;
                    mask = mask << 25;
                    numberAndMask = (number | mask);
                    number = numberAndMask;
                }
            }

            if (bitFive != bitTwentySix)
            {
                if (bitFive == 0)
                {
                    mask = 1;
                    mask = ~(mask << 26);
                    numberAndMask = (number & mask);
                    number = numberAndMask;
                    
                }
                else
                {
                    mask = 1;
                    mask = mask << 26;
                    numberAndMask = (number | mask);
                    number = numberAndMask;
                }
            }

            if (bitTwentySix != bitFive)
            {
                if (bitTwentySix == 0)
                {
                    mask = 1;
                    mask = ~(mask << 5);
                    numberAndMask = (number & mask);
                    number = numberAndMask;
                }
                else
                {
                    mask = 1;
                    mask = mask << 5;
                    numberAndMask = (number | mask);
                    number = numberAndMask;
                }
            }

            if (bitTwentyFive != bitFour)
            {
                if (bitTwentyFive == 0)
                {
                    mask = 1;
                    mask = ~(mask << 4);
                    numberAndMask = (number & mask);
                    number = numberAndMask;
                }
                else
                {
                    mask = 1;
                    mask = mask << 4;
                    numberAndMask = (number | mask);
                    number = numberAndMask;
                }
            }

            if ( bitTwentyFour!= bitThree)
            {
                if (bitTwentyFour == 0)
                {
                    mask = 1;
                    mask = ~(mask << 3);
                    numberAndMask = (number & mask);
                    number = numberAndMask;
                }
                else
                {
                    mask = 1;
                    mask = mask << 3;
                    numberAndMask = (number | mask);
                    number = numberAndMask;
                }
            }
            string newStr = Convert.ToString(number, 2).PadLeft(32,'0');
            Console.WriteLine(newStr);

        }
    }
}
