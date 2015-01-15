/*      Problem 6. Strings and Objects

    Declare two string variables and assign them with Hello and World.
    Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
    Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).
*/
using System;

class StrAndObj
{
    static void Main(string[] args)
    {
        string hello = "Hello";
        string world = "World";
        object helloWorld = hello + " " + world;
        string greetings = (string)helloWorld;
        Console.WriteLine("string hello is: {0}\nstring world is: {1}\nobject helloWorld is: {2}\nstring greetings is: {3}",hello,world,helloWorld,greetings);
    }
}

