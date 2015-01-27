/*      Problem 13. Binary to Decimal Number

    Using loops write a program that converts a binary integer number to its decimal form.
    The input is entered as string. The output should be a variable of type long.
    Do not use the built-in .NET functionality.
 */
using System;
class BinToDec
{
    static void Main(string[] args)
    {
        string binaryNumber = Console.ReadLine();
        int count = binaryNumber.Length - 1;

        long decimalNumber = 0;

        for (int i = 0; i < binaryNumber.Length; i++)
        {
            decimalNumber += long.Parse(binaryNumber[i].ToString()) * (long)Math.Pow(2, (count - i));
        }
        Console.WriteLine(decimalNumber);
    }
}

