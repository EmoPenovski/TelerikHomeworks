/*      Problem 10. Point Inside a Circle & Outside of a Rectangle

    Write an expression that checks for given point (x, y) if it is within the circle K({1, 1}, 1.5) and out of the rectangle R(top=1, left=-1, width=6, height=2).
 */
using System;
class InAndOut
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter coordinate X: ");
        double xCoord = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter coordinate Y: ");
        double yCoord = double.Parse(Console.ReadLine());
        bool isInCircle = (Math.Pow(xCoord - 1, 2) + Math.Pow(yCoord - 1, 2)) <= Math.Pow(1.5, 2);
        bool isInRectangle = (xCoord <= 5 && xCoord >= -1) && (yCoord <= 1 && yCoord >= -1);

        if (isInCircle && isInRectangle)
        {
            Console.WriteLine("NO:The point with coords x={0} and y={1} is inside circle and inside rectangle",xCoord,yCoord);
        }
        else if (isInCircle && !isInRectangle)
        {
            Console.WriteLine("YES:The point with coords x={0} and y={1} is inside circle and outside rectangle",xCoord,yCoord);
        }
        else if (!isInCircle && !isInRectangle)
        {
            Console.WriteLine("NO:The point with coords x={0} and y={1} is outside circle and outside rectangle",xCoord,yCoord);
        }
        else if (!isInCircle && isInRectangle)
        {
            Console.WriteLine("NO:The point with coords x={0} and y={1} is outside circle and inside rectangle",xCoord,yCoord);
        }
    }
}

