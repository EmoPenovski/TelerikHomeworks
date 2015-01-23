/*      Problem 4. Number Comparer

    Write a program that gets two numbers from the console and prints the greater of them.
    Try to implement this without if statements.
 */
using System;
class CompareNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter first number: ");
        double firstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter second nubmer: ");
        double secondNumber = double.Parse(Console.ReadLine());
        bool compare = firstNumber > secondNumber;
        if (compare == true)
        {
            Console.WriteLine("greater --->{0} > {1}",firstNumber,secondNumber);
        }
        else
        {
            Console.WriteLine("{0} < {1}<---greater",firstNumber,secondNumber);
        }
    }
}

