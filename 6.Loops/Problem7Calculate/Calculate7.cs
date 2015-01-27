/*      Problem 7. Calculate N! / (K! * (N-K)!)

    In combinatorics, the number of ways to choose k different members out of a group of n different elements (also known as the number of combinations) is calculated by the following formula: formula For example, there are 2598960 ways to withdraw 5 cards out of a standard deck of 52 cards.
    Your task is to write a program that calculates n! / (k! * (n-k)!) for given n and k (1 < k < n < 100). Try to use only two loops.
 */
using System;
class Calculate7
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        long n = long.Parse(Console.ReadLine());
        Console.Write("Enter k (k < n): ");
        long k = long.Parse(Console.ReadLine());
        
        if (k<=1 || k>=n || n>=100)
        {
            Console.WriteLine("Invalid Input!");
        }
        else
        {
            double nFactoriel = 1;
            double kFactoriel = 1;
            double nAndKFactoriel = n - k;
            double sum = 0;
            for (long i = 1, j = (n - k - 1); i <= n; i++, j--)
            {
                nFactoriel *= i;
                if (j>=1)
                {
                    nAndKFactoriel *= j;
                }
            }
            for (long i = 1; i <= k; i++)
            {
                kFactoriel *= i;
            }
            sum = nFactoriel / (kFactoriel * nAndKFactoriel);
            Console.WriteLine("Sum = "+ sum);
        }
    }
}

