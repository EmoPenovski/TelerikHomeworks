﻿/*      Problem 3. Divide by 7 and 5

    Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.
 */
using System;
class Divide
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number to check:");
        int divideNumber = int.Parse(Console.ReadLine());
        bool isDivided = divideNumber % 7 == 0 && divideNumber % 5 == 0;
        Console.WriteLine(isDivided? "True" : "False");
    }
}

