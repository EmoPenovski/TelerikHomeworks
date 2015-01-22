/*      Problem 4. Rectangles

    Write an expression that calculates rectangle’s perimeter and area by given width and height.
 */
using System;
class PeriAndArea
{
    static void Main(string[] args)
    {
        Console.Write("Enter the height of the rectangle:");
        double height = double.Parse(Console.ReadLine());
        Console.Write("Enter the width of the rectagnle:");
        double width = double.Parse(Console.ReadLine());
        double areaOfRectangle = height * width;
        double periOfRectangle = (2 * height) + (2 * width);
        Console.WriteLine("The are of the rectangle is: {0}",areaOfRectangle);
        Console.WriteLine("The perimeter of the rectangle is: {0}",periOfRectangle);
    }
}

