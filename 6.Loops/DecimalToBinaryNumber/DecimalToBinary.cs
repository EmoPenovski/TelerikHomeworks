/*      Problem 14. Decimal to Binary Number

    Using loops write a program that converts an integer number to its binary representation.
    The input is entered as long. The output should be a variable of type string.
    Do not use the built-in .NET functionality.
 */
using System;
class DecimalToBinary
{
    static void Main(string[] args)
    {
        int decimalNumber = int.Parse(Console.ReadLine());

        // logic
        string binaryNumber = String.Empty;
        if (decimalNumber != 0)
        {
            while (decimalNumber > 0)
            {
                binaryNumber += Convert.ToString(decimalNumber % 2);
                decimalNumber /= 2;
            }

            for (int i = binaryNumber.Length - 1; i >= 0; i--)
            {
                Console.Write(binaryNumber[i]);
            }
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine(0);
        }
    }
}

