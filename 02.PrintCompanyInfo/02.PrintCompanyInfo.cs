/*Problem 2. Print Company Information

A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
Write a program that reads the information about a company and its manager and prints it back on the console.
Company name:	Telerik Academy
Company address:	31 Al. Malinov, Sofia
Phone number:	+359 888 55 55 555
Fax number:	2
Web site:	http://telerikacademy.com/
Manager first name:	Nikolay
Manager last name:	Kostov
Manager age:	25
Manager phone:	+359 2 981 981
 */

using System;

namespace _02.PrintCompanyInfo
{
    class Program
    {
        static void Main()
        {
            //gather all the information
            Console.Write("Company name: ");
            string companyName = Console.ReadLine();
            Console.Write("Company address: ");
            string companyAddress = Console.ReadLine();
            Console.Write("Phone number: ");
            string phoneNumber = Console.ReadLine();
            Console.Write("Fax number: ");
            string fax = Console.ReadLine();
            Console.Write("Web site: ");
            string website = Console.ReadLine();
            Console.Write("Manager first name: ");
            string first = Console.ReadLine();
            Console.Write("Manager last name: ");
            string last = Console.ReadLine();
            Console.Write("Manager age: ");
            string age = Console.ReadLine();
            Console.Write("Manager phone: ");
            string managerPhone = Console.ReadLine();
            Console.WriteLine();

            //print it out as required
            Console.WriteLine("{0}\nAddress:{1}\nTel. {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} ({7}, {8})", 
                companyName, companyAddress, phoneNumber, fax, website, first, last, age, managerPhone);
        }
    }
}
