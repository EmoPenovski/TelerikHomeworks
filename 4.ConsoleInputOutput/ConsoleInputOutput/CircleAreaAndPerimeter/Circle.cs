/*      Problem 3. Circle Perimeter and Area
 
    Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.
 */
using System;
class Circle
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter radius of the circle: ");
        double radius = double.Parse(Console.ReadLine());
        double area = (radius * radius) * Math.PI;
        double perimeter = 2 * (Math.PI * radius);
        Console.WriteLine("The area of the circle is: {0:0.00} ",area);
        Console.WriteLine("The perimeter of the circle is: {0:0.00} ",perimeter);
    }
}

