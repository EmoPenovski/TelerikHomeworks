/*      Problem 5. Boolean Variable

    Declare a Boolean variable called isFemale and assign an appropriate value corresponding to your gender.
    Print it on the console.
*/
using System;

class IsFemale
{
    static void Main(string[] args)
    {
        Boolean isFemale;
        Console.WriteLine("Write you gender(type \"male\"or \"female\"):");
        string myGender = Console.ReadLine();
        if (myGender == "female")
        {
            isFemale = true;
            Console.WriteLine("You are female:"+ isFemale);
        }
        else
        {
            isFemale = false;
            Console.WriteLine("Your are not female:" + isFemale);
        }

    }
}

