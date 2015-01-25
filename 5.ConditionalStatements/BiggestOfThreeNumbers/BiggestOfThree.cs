/*      Problem 5. The Biggest of 3 Numbers

    Write a program that finds the biggest of three numbers.
 */
using System;
class BiggestOfThree
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        double biggestNumber;

        if (firstNumber>secondNumber)
        {
            if (firstNumber>thirdNumber)
            {
                biggestNumber = firstNumber;
            }
            else
            {
                biggestNumber = thirdNumber;
            }
        }
        else
        {
            if (secondNumber>thirdNumber)
            {
                biggestNumber=secondNumber;
            }
            else
            {
                biggestNumber=thirdNumber;
            }
        }

        Console.WriteLine("The biggest number is : {0}",biggestNumber);
    }
}

