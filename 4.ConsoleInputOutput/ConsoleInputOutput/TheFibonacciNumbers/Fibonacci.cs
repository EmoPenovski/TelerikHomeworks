/*      Problem 10. Fibonacci Numbers

    Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
    Note: You may need to learn how to use loops.
 */
using System;
class Fibonacci
{
    static void Main(string[] args)
    {
        int previousNumber = -1;
        int nextNumber = 1;
        Console.WriteLine("Enter the total number you want to display the series: ");
        int number = int.Parse(Console.ReadLine());
        for (int i = 2; i <= number; i++)
        {
            int sum = previousNumber + nextNumber;
            previousNumber = nextNumber;
            nextNumber = sum;
            Console.Write("{0}, ", nextNumber);
        }
        Console.WriteLine();
    }
}

