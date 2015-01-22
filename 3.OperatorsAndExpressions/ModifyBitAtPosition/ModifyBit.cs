/*      Problem 14. Modify a Bit at Given Position

    We are given an integer number n, a bit value v (v=0 or 1) and a position p.
    Write a sequence of operators (a few lines of C# code) that modifies n to hold the value v at the position p from the binary representation of n while preserving all other bits in n.
 */
using System;
class ModifyBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the position:");
        int position = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter the value (0 or 1) you want to set:");
        byte bitValue = byte.Parse(Console.ReadLine());
        int mask = 1 << position;
        int numberOrMask;
        if (bitValue==1)
        {
            numberOrMask = number | mask;
        }
        else
        {
            numberOrMask = number ^ mask;
        }
        Console.WriteLine("The new number with {0} value on {1} position is:{2}", bitValue, position, numberOrMask);

    }
}

