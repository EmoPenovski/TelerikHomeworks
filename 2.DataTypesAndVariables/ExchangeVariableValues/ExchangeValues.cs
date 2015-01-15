/*      Problem 9. Exchange Variable Values

    Declare two integer variables a and b and assign them with 5 and 10 and after that exchange their values by using some programming logic.
    Print the variable values before and after the exchange.
*/
using System;

class ExchangeValues
{
    static void Main(string[] args)
    {
        int a = 5;
        int b = 10;
        Console.WriteLine("First results:");
        Console.WriteLine("a={0}", a); Console.WriteLine("b={0}",b);
        a = a + b;
        b = a - b;
        a = a - b;
        Console.WriteLine("The results after exchange:");
        Console.WriteLine("a=" + a);
        Console.WriteLine("b=" + b);
    }
}

