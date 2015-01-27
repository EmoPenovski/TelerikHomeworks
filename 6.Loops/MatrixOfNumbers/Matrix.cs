/*      Problem 9. Matrix of Numbers

    Write a program that reads from the console a positive integer number n (1 = n = 20) and prints a matrix like in the examples below. Use two nested loops.
 */
using System;
class Matrix
{
    static void Main(string[] args)
    {
        Console.Write("Enter the size of the matrix: ");
        int n = int.Parse(Console.ReadLine());
        if (n<1 || n>20)
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            for (int i = 1; i <= n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,2} ",i+j);
                }
                Console.WriteLine();
            }
        }
    }
}

