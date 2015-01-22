/*      Problem 12. Extract Bit from Integer

    Write an expression that extracts from given integer n the value of given bit at index p.
 */
using System;
class ExtractBit
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
        Console.WriteLine("The {0} bit of the number {1} is: {2}",position,number,bit);
    }
}

