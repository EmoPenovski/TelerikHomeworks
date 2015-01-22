/*      Problem 6. Four-Digit Number

    Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
    Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
    Prints on the console the number in reversed order: dcba (in our example 1102).
    Puts the last digit in the first position: dabc (in our example 1201).
    Exchanges the second and the third digits: acbd (in our example 2101).
    The number has always exactly 4 digits and cannot start with 0.
 */
using System;
class FourDigits
{
    static void Main(string[] args)
    {
        Console.Write("Enter a four digit number (e.g 2015):");
        int number = int.Parse(Console.ReadLine());
        Console.WriteLine("Your number is:{0}", number);
        while ((((number / 1000) % 10) == 0) || (number > 9999))
        {
            Console.Write("Wrong Number! Enter four-digit number: ");
            number = int.Parse(Console.ReadLine());
        }
        int firstDigit = (number / 1000) % 10;
        int secondDigit = (number / 100) % 10;
        int thirdDigit = (number / 10) % 10;
        int fourthDigit = (number % 10);
        Console.WriteLine("First digit is: {0}\nSecond digit is: {1}\nThird digit is: {2}\nFourth digit is: {3}",firstDigit,secondDigit,thirdDigit,fourthDigit);
        int sumOfDigits = firstDigit + secondDigit + thirdDigit + fourthDigit;
        Console.WriteLine("The sum of the digits is:"+sumOfDigits);
        Console.WriteLine("Reversed digits:{0}{1}{2}{3}", fourthDigit, thirdDigit, secondDigit, firstDigit);
        Console.WriteLine("Last digit in first position:{0}{1}{2}{3}",fourthDigit,firstDigit,secondDigit,thirdDigit);
        Console.WriteLine("Second and third digits exchanged:{0}{1}{2}{3}",firstDigit,thirdDigit,secondDigit,fourthDigit);
        
        
        
    }
}

