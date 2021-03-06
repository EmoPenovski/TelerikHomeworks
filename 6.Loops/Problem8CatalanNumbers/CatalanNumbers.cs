﻿/*      Problem 8. Catalan Numbers

    In combinatorics, the Catalan numbers are calculated by the following formula: catalan-formula
    Write a program to calculate the nth Catalan number by given n (1 <= n <= 100).
 */
using System;
class CatalanNumbers
{
    static void Main(string[] args)
    {
        Console.Write("Enter n: ");
        double n = double.Parse(Console.ReadLine());
        double sum=1;
        if (n<1 || n>100)
        {
            Console.WriteLine("Invalid number!");
        }
        else
        {
            for (double k = 2; k <= n; k++)
            {
                sum *= ((n / k) + 1);
            }
            Console.WriteLine("The catalan numbers are: {0}", sum);
        }
        /* Printing N catalan numbers: // just for me 
         * Console.Write("n = ");
            long n = int.Parse(Console.ReadLine());

            if (n == 0)
            {
                Console.WriteLine(1);
            }
            else if (n < 1 || n > 100)
            {
                Console.Write("Invalid input!");
            }
            else
            {

                long catalanNumber = 1;
                Console.Write("{0} ", catalanNumber);

                for (int j = 1; j <= n; j++)
                {

                    long nWithTwoFactorial = 2 * j;
                    for (int i = 2 * j - 1; i >= 1; i--)
                    {
                        nWithTwoFactorial *= i;
                    }

                    long nPlusOneFactorial = j + 1;
                    for (int i = j; i >= 1; i--)
                    {
                        nPlusOneFactorial *= i;
                    }

                    long nFactorial = j;
                    for (int i = j - 1; i >= 1; i--)
                    {
                        nFactorial *= i;
                    }

                    catalanNumber = nWithTwoFactorial / (nPlusOneFactorial * nFactorial);
                    Console.Write("{0} ", catalanNumber);
                }
            }
        }
         */
    }
}

