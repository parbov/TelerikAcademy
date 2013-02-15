using System;

class Program
{
    static void Main()
    {
        string[] firstTwenty = { "", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine", "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
        string[] arrTens = { "twenty", "thirty", "fourty", "fifty", "sixty", "seventy", "eighty", "ninety" };
        int number = 3000;

        while (number > 999 || number < 0)
        {
            Console.WriteLine("Enter a number");
            number = int.Parse(Console.ReadLine());
        }
        int ones = number % 10;
        int tens = (number / 10) % 10;
        int hundreds = (number / 100) % 10;
        int isSpecialNumber = number % 100;

        if (number == 0)
        {
            Console.WriteLine("{0}  -> Zero", number);
        }
        else
        {
            if (hundreds != 0)
            {
                Console.Write("{0} hundred", firstTwenty[hundreds]);
            }
            if ((isSpecialNumber < 20) && (isSpecialNumber != 0))
            {
                if (hundreds != 0) Console.Write(" and");
                Console.Write(" {0} \n", firstTwenty[isSpecialNumber]);
            }
            else if (tens == 0 && ones == 0)
            {
                Console.WriteLine("");
            }
            else
            {
                if (hundreds != 0) Console.Write(" and");
                Console.WriteLine(" {0} {1}", arrTens[tens - 2], firstTwenty[ones]);
            }
        }
    }
}

