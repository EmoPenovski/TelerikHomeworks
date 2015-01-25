/*      Problem 7. Sort 3 Numbers with Nested Ifs

    Write a program that enters 3 real numbers and prints them sorted in descending order.
    Use nested if statements.
    Note: Don’t use arrays and the built-in sorting functionality.
 */
using System;
class SortThreeNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        double biggestNumber = 0;
        double middleNumber = 0;
        double smallerNumber = 0;
        if (firstNumber == secondNumber && secondNumber == thirdNumber)
        {
            Console.WriteLine("{0}={1}={2}", firstNumber, secondNumber, thirdNumber);
        }
        else
        {
            if (firstNumber > secondNumber && secondNumber > thirdNumber)
            {
                biggestNumber = firstNumber;
                middleNumber = secondNumber;
                smallerNumber = thirdNumber;
            }
            else if (firstNumber > thirdNumber && thirdNumber > secondNumber)
            {
                biggestNumber = firstNumber;
                middleNumber = thirdNumber;
                smallerNumber = secondNumber;
            }
            else if (secondNumber > firstNumber && firstNumber > thirdNumber)
            {
                biggestNumber = secondNumber;
                middleNumber = firstNumber;
                smallerNumber = thirdNumber;
            }
            else if (secondNumber > thirdNumber && thirdNumber > firstNumber)
            {
                biggestNumber = secondNumber;
                middleNumber = thirdNumber;
                smallerNumber = firstNumber;
            }
            else if (thirdNumber > firstNumber && firstNumber > secondNumber)
            {
                biggestNumber = thirdNumber;
                middleNumber = firstNumber;
                smallerNumber = secondNumber;
            }
            else
            {
                biggestNumber = thirdNumber;
                middleNumber = secondNumber;
                smallerNumber = firstNumber;
            }

            Console.WriteLine("{0} > {1} > {2}", biggestNumber, middleNumber, smallerNumber);
        }
    }
}

