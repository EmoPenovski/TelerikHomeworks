/*      Problem 7. Point in a Circle

    Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).
 */
using System;
class PointInCircle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coordinate X: ");
        double xCoordinate = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate Y: ");
        double yCoordinate = double.Parse(Console.ReadLine());
        double radius = 2;
        Console.WriteLine(((xCoordinate*xCoordinate)+(yCoordinate*yCoordinate)<(radius*radius))? "In" : "Out");

    }
}

