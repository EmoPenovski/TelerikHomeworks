﻿/*      Problem 15.* Bits Exchange

    Write a program that exchanges bits 3, 4 and 5 with bits 24, 25 and 26 of given 32-bit unsigned integer.
 */
using System;
class ExchangeBits
{
    static void Main(string[] args)
    {
        Console.Write("Input n:");
        uint n = uint.Parse(Console.ReadLine());
        Console.WriteLine("Binary representation of n:{0,-10}", Convert.ToString(n, 2).PadLeft(32, '0'));
        Console.WriteLine(new string('*', 50));
        uint firstBits = (n >> 3) & 7;
        uint secondBits = (n >> 24) & 7;
        uint maskFristBits = 7 << 3;
        uint maskSecondBits = 7 << 24;
        n = n & ~maskFristBits | (secondBits << 3);
        n = n & ~maskSecondBits | (firstBits << 24);
        Console.WriteLine("Result: {0}",n);
        Console.WriteLine("Binary representation of result: {0}", Convert.ToString(n,2).PadLeft(32,'0'));
        Console.WriteLine(new string ('*',50));
    }
}

