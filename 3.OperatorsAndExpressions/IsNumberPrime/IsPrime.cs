/*      Problem 8. Prime Number Check

    Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
    Note: You should check if the number is positive
 */
using System;
class IsPrime
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number:");
        int number = int.Parse(Console.ReadLine());
        bool check = number>=100;
        if (check)
        {
            Console.WriteLine("The number you have entered is invalid");
        }
        else if ((number==1 || number==2 || number==3 || number==5 || number==7)^((number % 2 != 0) && (number % 3 != 0) && (number % 5 != 0) && (number % 7 != 0)))
        {
            Console.WriteLine("The number is prime");
        }
        else
        {
            Console.WriteLine("The number is not prime");
        }
    }
}

