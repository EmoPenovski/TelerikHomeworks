/*      Problem 6. Calculate N! / K!

    Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
    Use only one loop.
 */
using System;
class Calculate6
{
    static void Main(string[] args)
    {
        Console.Write("Enter N: ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("Enter k: ");
        long k = long.Parse(Console.ReadLine());

        if ((k <= 1) || (n <= k) || (n >= 100))
        {
            Console.WriteLine("Invalid input!");
        }
        else
        {
            long nFactoriel = n;
            for (long i = n-1; i>=1; i--)
            {
                nFactoriel *= i;
            }
            long kFactoriel = k;
            for (long i = k-1; i>=1; i--)
            {
                kFactoriel *= i;
            }
            long sum = nFactoriel / kFactoriel;
            Console.WriteLine(sum);
        }
        
    }
}

