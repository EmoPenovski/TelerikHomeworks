/*      Problem 6. The Biggest of Five Numbers

    Write a program that finds the biggest of five numbers by using only five if statements.
 */
using System;
class BiggestOfFive
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fourth number: ");
        double fourthNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter the fifth number: ");
        double fifthNumber = double.Parse(Console.ReadLine());
        double biggestNumber=0;

        if (firstNumber > secondNumber && firstNumber > thirdNumber && firstNumber > fourthNumber && firstNumber > fifthNumber)
        {
            biggestNumber = firstNumber;
        }
        else if (secondNumber > firstNumber && secondNumber > thirdNumber && secondNumber > fourthNumber && secondNumber > fifthNumber)
        {
            biggestNumber = secondNumber;
        }
        else if (thirdNumber > firstNumber && thirdNumber > secondNumber && thirdNumber > fourthNumber && thirdNumber > fifthNumber)
        {
            biggestNumber = thirdNumber;
        }
        else if (fourthNumber > firstNumber && fourthNumber > secondNumber && fourthNumber > thirdNumber && fourthNumber > fifthNumber)
        {
            biggestNumber = fourthNumber;
        }
        else
        {
            biggestNumber = fifthNumber;
        }

        Console.WriteLine("The biggest number is: {0}",biggestNumber);
    }

}

