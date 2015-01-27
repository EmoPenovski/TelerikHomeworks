/*      Problem 3. Min, Max, Sum and Average of N Numbers

    Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number, the sum and the average of all numbers (displayed with 2 digits after the decimal point).
    The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
    The output is like in the examples below.
 */
using System;
class MinMaxSumNumbers
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the range of the sequence: ");
        int range = int.Parse(Console.ReadLine());
        int max = int.MinValue;
        int min = int.MaxValue;
        int sum = 0;
        int input;
        for (int i = 0; i < range; i++)
        {
            Console.Write("Number {0} --> ", i+1);
            input = int.Parse(Console.ReadLine());
            sum += input;
            if (input > max)
            {
                max = input;
            }
            if (input < min)
            {
                min = input;
            }
            
        }
        double avg = (double)sum / (double)range;
        Console.WriteLine("Min={0}\nMax={1}\nSum={2}\nAverage={3:f2}",min,max,sum,avg);
    }
}

