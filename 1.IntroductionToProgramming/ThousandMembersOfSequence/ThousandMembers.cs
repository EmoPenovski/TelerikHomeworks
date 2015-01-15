/*          Problem 16.* Print Long Sequence
 Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
 You might need to learn how to use loops in C# (search in Internet).
 */
using System;

class ThousandMembers
{
    static void Main(string[] args)
    {
        int number = 2;
        for (int i = 2; i <= 1000; i++)
        {
            Console.Write(i % 2 == 0 ? "{0} " : "-{0} ", number);
            number++;
        }
        Console.WriteLine();
    }
}
