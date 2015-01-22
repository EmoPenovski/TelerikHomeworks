/*      Problem 2. Gravitation on the Moon

    The gravitational field of the Moon is approximately 17% of that on the Earth.
    Write a program that calculates the weight of a man on the moon by a given weight on the Earth.
 */
using System;
class Gravity
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter your weight:");
        double earthWeight = double.Parse(Console.ReadLine());
        Console.WriteLine("Your weight on the Earth is {0}", earthWeight);
        double moonWeight = earthWeight * 0.17;
        Console.WriteLine("Your weight on the Moon is {0}", moonWeight);
    }
}
