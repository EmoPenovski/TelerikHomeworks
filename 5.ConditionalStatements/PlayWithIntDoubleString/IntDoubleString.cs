/*      Problem 9. Play with Int, Double and String

    Write a program that, depending on the user’s choice, inputs an int, double or string variable.
    If the variable is int or double, the program increases it by one.
    If the variable is a string, the program appends * at the end.
    Print the result at the console. Use switch statement.
 */
using System;
class IntDoubleString
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please choose a type (double ,int or string): ");
        string type = Console.ReadLine();
        
        switch (type)
        {
            case "double":
                Console.Write("Enter double number: ");
                double doubleNumber = double.Parse(Console.ReadLine());
                Console.WriteLine("Result is "+doubleNumber+"+1={0}",doubleNumber+1);
                break;
            case "int":
                Console.Write("Enter int number: ");
                int intNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Result is "+intNumber+"+1={0}",intNumber+ 1);
                break;
            case "string":
                Console.Write("Enter text: ");
                string stringThing = Console.ReadLine();
                Console.WriteLine("Result is "+stringThing+"*");
                break;
        }
    }
}

