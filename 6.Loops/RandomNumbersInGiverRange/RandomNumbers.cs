/*      Problem 11. Random Numbers in Given Range

    Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].
 */
using System;
class RandomNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter range: ");
        int range = int.Parse(Console.ReadLine());
        Random randomNumbers = new Random(range);
        Console.Write("Enter left range:");
        int minValue = int.Parse(Console.ReadLine());
        Console.Write("Enter right range:");
        int maxValue = int.Parse(Console.ReadLine());
        if (minValue == maxValue)
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            for (int i = 1; i < range; i++)
            {
                Console.WriteLine(randomNumbers.Next(minValue,maxValue+1));
            }
        }
    }
}

