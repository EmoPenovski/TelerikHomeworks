/*      Problem 12. Null Values Arithmetic

    Create a program that assigns null values to an integer and to a double variable.
    Try to print these variables at the console.
    Try to add some number or the null literal to these variables and print the result.
*/
using System;

class TypeNull
{
    static void Main(string[] args)
    {
        int? intValue = null;
        double? doubleValue = null;
        Console.WriteLine("The value of int number is:"+intValue);
        Console.WriteLine("The value of double number is:"+doubleValue);
        intValue = 5;
        doubleValue = 1.4198269186;
        Console.WriteLine("The new value of int number is :"+intValue);
        Console.WriteLine("The new value of double number is:"+doubleValue);
    }
}

