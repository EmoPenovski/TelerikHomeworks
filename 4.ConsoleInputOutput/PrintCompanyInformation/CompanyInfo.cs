/*      Problem 2. Print Company Information

    A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
    Write a program that reads the information about a company and its manager and prints it back on the console.
 */
using System;
class CompanyInfo
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the name of the Company: ");
        string companyName = Console.ReadLine();
        Console.WriteLine("Enter the address of the Company: ");
        string companyAddress = Console.ReadLine();
        Console.WriteLine("Enter company phone number: ");
        ulong companyPhone = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter company fax number: ");
        int faxNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter company web site");
        string webSite = Console.ReadLine();
        Console.WriteLine("Enter Manager first name: ");
        string firstName = Console.ReadLine();
        Console.WriteLine("Enter Manager last name: ");
        string lastName = Console.ReadLine();
        Console.WriteLine("Enter manager age: ");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Enter Manager phone number: ");
        ulong managerPhone = ulong.Parse(Console.ReadLine());
        Console.WriteLine("    {0}\nAdress: {1}\nCompany phone: {2}\nFax: {3}\nWeb site: {4}\nManager: {5} {6} (age: {7},tel.{8})",companyName,companyAddress,companyPhone,faxNumber,webSite,firstName,lastName,age,managerPhone);

    }
}

