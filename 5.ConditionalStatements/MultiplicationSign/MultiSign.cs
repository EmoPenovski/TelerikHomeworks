/*      Problem 4. Multiplication Sign

    Write a program that shows the sign (+, - or 0) of the product of three real numbers, without calculating it.
    Use a sequence of if operators.
 */
using System;
class MultiSign
{
    static void Main(string[] args)
    {
        Console.Write("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter second number: ");
        double secondNumber = double.Parse(Console.ReadLine());
        Console.Write("Enter third number: ");
        double thirdNumber = double.Parse(Console.ReadLine());
        sbyte count = 0;
        string sign = "";
        
        if (firstNumber < 0)
        {
            count++;
        }
        if (secondNumber < 0)
        {
            count++;
        }
        if (thirdNumber < 0)
        {
            count++;
        }
        if (count % 2 != 0)
        {
            sign = "-";
        }
        else
        {
            sign = "+";
        }
        if (firstNumber==0 || secondNumber==0 || thirdNumber==0)
        {
            sign = "0";
        }
        Console.WriteLine(sign);
    }
}

