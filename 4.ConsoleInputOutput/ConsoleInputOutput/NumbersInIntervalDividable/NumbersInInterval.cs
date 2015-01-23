/*      Problem 11.* Numbers in Interval Dividable by Given Number

    Write a program that reads two positive integer numbers and prints how many numbers p exist between them such that the reminder of the division by 5 is 0.
 */
using System;
class NumbersInInterval
{
    static void Main(string[] args)
    {
        Console.Write("Enter the start number: ");
        uint startNumber = uint.Parse(Console.ReadLine());
        Console.Write("Enter the end number: ");
        uint endNumber = uint.Parse(Console.ReadLine());
        uint p = 0;

        for (uint i = startNumber; i <= endNumber; i++)
        {
            if (i % 5 == 0)
            {
                Console.WriteLine("Number we want to see: {0}",i);
                p++;
            }
        }
        Console.WriteLine();
        Console.WriteLine("Total numbers in this range which are divided by 5 without remainer: {0}",p);
    }
}

