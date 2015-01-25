/*      Problem 1. Exchange If Greater

    Write an if-statement that takes two double variables a and b and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.
 */
using System;
class ExchangeGreater
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());

        if (firstNumber>secondNumber)
        {
            firstNumber = firstNumber + secondNumber;
            secondNumber = firstNumber - secondNumber;
            firstNumber = firstNumber - secondNumber;
        }
        Console.Write("{0} ",firstNumber); Console.WriteLine("{0}",secondNumber);
    }
}

