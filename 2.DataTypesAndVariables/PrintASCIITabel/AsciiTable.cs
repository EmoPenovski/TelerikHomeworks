/*      Problem 14.* Print the ASCII Table

    Find online more information about ASCII (American Standard Code for Information Interchange) and write a program that prints the entire ASCII table of characters on the console (characters from 0 to 255).
    Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

    Note: You may need to use for-loops (learn in Internet how).
*/
using System;
using System.Text;

class AsciiTable
{
    static void Main(string[] args)
    {
        Console.WriteLine("|---------|-----|-------|-----|--------|--------|");
        Console.WriteLine("| Unicode | Hex |  Dec  | Oct | Bynary | Symbol |");
        Console.WriteLine("|---------|-----|-------|-----|--------|--------|");

        int i;
        Console.OutputEncoding = Encoding.Unicode;
        for (i = 0; i <= 255; i++)
        {

            Console.WriteLine("| U+{0:x4}  |  {0:x2} |  {0:d3}  |  {1}  |   {2}    |   {3}    |", i, (Convert.ToString(i, 8)), (Convert.ToString(i, 2)), (char)i);
        }
           
    }
}
