/*      Problem 11. Bitwise: Extract Bit #3

    Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
    The bits are counted from right to left, starting from bit #0.
    The result of the expression should be either 1 or 0.
 */
using System;
class ThirdBit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter number: ");
        uint number = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of the number:\n{0,-10}", Convert.ToString(number, 2).PadLeft(32, '0'));
        uint result =((number>>3)&1);
        Console.WriteLine("The result is: {0}",result);
    }
}

