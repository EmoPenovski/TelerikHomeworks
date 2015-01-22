/*  Problem 13. Check a Bit at Given Position

    Write a Boolean expression that returns if the bit at position p (counting from 0, starting from the right) 
    in given integer number n, has value of 1.
 */
using System;
class CheckIfBitis1
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of the number:\n{0,-10}", Convert.ToString(number, 2).PadLeft(32, '0'));
        Console.WriteLine("Enter the bit to extract");
        byte position = byte.Parse(Console.ReadLine());
        int mask = 1 << position;
        int mAndMask = mask & number;
        int bit = mAndMask >> position;
        bool check = (bit == 1);
        Console.WriteLine("The {0} bit of the number {1} has value {2}", position, number, bit);
        Console.WriteLine(check);
    }
}

