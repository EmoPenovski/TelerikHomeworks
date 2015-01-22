/*      Problem 5. Third Digit is 7?

    Write an expression that checks for given integer if its third digit from right-to-left is 7.
 */
using System;
class ThirdDigit
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number you want to check: ");
        int number = int.Parse(Console.ReadLine());
        int check = number / 100;
        int seven = check % 10;
        bool isSeven = seven == 7;
        if ((seven == 7) || (seven == (-7)))
        {
            Console.WriteLine("TRUE:The third digit (right to left) is 7 !\n");
        }
        else if (number/10 ==0)
        {
            Console.WriteLine("False:There is only 1 digit\n");
        }
        else if (number/100 ==0)
        {
            Console.WriteLine("False:There are only 2 digits\n");
        }
        else
        {
            Console.WriteLine("False:The third digit (right to left) isnt 7 , it is {0}", seven);
        }
    }
}

