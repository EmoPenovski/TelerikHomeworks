/*      Problem 1. Odd or Even Integers

    Write an expression that checks if given integer is odd or even.
 */
using System;
class OddOrEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the nubmer you want to check:");
        int number = int.Parse(Console.ReadLine());
        bool oddOrEven = (number % 2 == 0);
        Console.WriteLine(oddOrEven ? "Even" : "Odd");
    }
}

