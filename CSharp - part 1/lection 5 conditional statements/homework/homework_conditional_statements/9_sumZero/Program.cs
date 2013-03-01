using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _9_sumZero
{
    class Program
    {
        static void Main()
        {
            int[] numbers = new int[5];
            int sum = 0;

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Enter value of integer [{0}]",i);
                numbers[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < 5; i++)
            {
                for (int j = i + 1; j < 5; j++)
                {
                    sum = numbers[i] + numbers[j];

                    if (sum == 0)
                    {
                        Console.WriteLine(numbers[i] + " " + numbers[j]);
                    }

                    for (int k = j + 1; k < 5; k++)
                    {
                        sum = numbers[i] + numbers[j] + numbers[k];
                        if (sum == 0)
                        {
                            Console.WriteLine(numbers[i] + " " + numbers[j] + " " + numbers[k]);
                        }

                        for (int l = k + 1;l < 5; l++)
                        {
                            sum = numbers[i] + numbers[j] + numbers[k] + numbers[l];
                            if (sum == 0)
                            {
                                Console.WriteLine(numbers[i] + " " + numbers[j] + " " + numbers[k] + " " + numbers[l]);
                            }

                        }
                    }
                }

            }
        }
    }
}
