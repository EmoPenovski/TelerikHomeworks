/*      Problem 9. Trapezoids

    Write an expression that calculates trapezoid's area by given sides a and b and height h.
 */
using System;
class AreaOfTrapezoid
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter side A: ");
        double aSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter side B: ");
        double bSide = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter height: ");
        double height = double.Parse(Console.ReadLine());
        double area = ((aSide + bSide) * height) / 2;
        Console.WriteLine("The area of trapezoid is: {0}",area);
    }
}

