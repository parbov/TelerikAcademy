using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_CompanyInfo
{
    class Program
    {

        static void Main()
        {
            Console.WriteLine("Enter name of the company");
            string companyName = Console.ReadLine();
            Console.WriteLine("Enter Company address");
            string address = Console.ReadLine();
            Console.WriteLine("Enter company phone number");
            string phoneNumber = Console.ReadLine();
            Console.WriteLine("Enter fax number");
            string fax = Console.ReadLine();
            Console.WriteLine("enter company website");
            string webSite = Console.ReadLine();

            Console.WriteLine("Enter manager's first name");
            string firstName = Console.ReadLine();
            Console.WriteLine("Enter manager's last name");
            string lastName = Console.ReadLine();
            Console.WriteLine("Enter manager's age");
            int age = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter manager's phone number");
            string managerPhone = Console.ReadLine();
            Console.Clear();

            Console.WriteLine("Company {0} has address {1} , phone number {2}, fax number {3} and web site {4}",companyName,address,phoneNumber,fax,webSite);
            Console.WriteLine("Manager is {0} {1} , {2} years old and a phone number {3}",firstName,lastName,age,managerPhone);
        }
    }
}
