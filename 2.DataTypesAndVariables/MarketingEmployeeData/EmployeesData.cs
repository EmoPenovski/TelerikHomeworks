/*      Problem 10. Employee Data

    A marketing company wants to keep record of its employees. Each record would have the following characteristics:

    First name
    Last name
    Age (0...100)
    Gender (m or f)
    Personal ID number (e.g. 8306112507)
    Unique employee number (27560000…27569999)
    Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.
*/
using System;

class EmployeesData
{
    static void Main(string[] args)
    {
        Console.WriteLine("First Name:");
        string firstName = Console.ReadLine();
        Console.WriteLine("Last Name:");
        string lastName = Console.ReadLine();
        Console.WriteLine("What is your Age?:");
        byte age = byte.Parse(Console.ReadLine());
        Console.WriteLine("Your Gender is (f or m):");
        char gender = char.Parse(Console.ReadLine());
        Console.WriteLine("Enter your personal ID:");
        ulong idNumber = ulong.Parse(Console.ReadLine());
        Console.WriteLine("Enter your unique employee number(27560000..27569999");
        int uniqueNumber = int.Parse(Console.ReadLine());
        Console.WriteLine("First name: {0}\nFamyly name: {1}\nAge: {2}\nIDnumber:{3}", firstName, lastName, age, idNumber);
        if (gender =='m')
        {
            Console.WriteLine("You are Male");
        }
        else if (gender == 'f')
        {
            Console.WriteLine("Your are Female");
        }
        else
        {
            Console.WriteLine("Wrong symbol");
        }
        if (uniqueNumber<27560000)
        {
            Console.WriteLine("Wrong ID number");
        }
        else if (uniqueNumber>27569999)
        {
            Console.WriteLine("Wrong ID number");
        }
        else
        {
            Console.WriteLine("Your unique number is: {0}",uniqueNumber);
        }
       //string firstName = "Luke";
       //string lastName = "Skywalker";
       //byte yourAge = 23;
       //char yourGender = 'm';
       //int idNumber = 256;
       //int uniqueNumber = 27560002;
       //Console.WriteLine("Employees Records:\nFirst Name:{0} \nLast Name:{1} \nAge:{2} \nGender:{3} \nID Number:{4} \nUnique Number:{5}.", firstName, lastName, yourAge, yourGender, idNumber, uniqueNumber);

    }
}

