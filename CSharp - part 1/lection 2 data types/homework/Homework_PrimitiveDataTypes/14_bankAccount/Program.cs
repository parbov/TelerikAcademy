using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _14_bankAccount
{
    class Program
    {
        static void Main()
        {
            string firstName = "Petko";
            string midName = "Stanimirov";
            string lastName = "Arbov";
            double balance = 1234.56;
            string bankName = "Societe generale";
            long bicCode = 12345678;
            string iban = "BG04US" + bicCode.ToString();
            long cardNum1 = 1234567890123456;
            long cardNum2 = 2345678901234567;
            long cardNum3 = 3456789012345678;

            Console.WriteLine("Account holder: {0} {1} {2}",firstName,midName,lastName);
            Console.WriteLine("Bank: {0}, BIC code {1}, IBAN: {2}",bankName,bicCode,iban);
            Console.WriteLine("Account balance: {0}",balance);
            Console.WriteLine("With cards:");
            Console.WriteLine(cardNum1);
            Console.WriteLine(cardNum2);
            Console.WriteLine(cardNum3);

        }
    }
}
