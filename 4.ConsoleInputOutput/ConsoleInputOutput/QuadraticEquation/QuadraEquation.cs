/*      Problem 6. Quadratic Equation
 
    Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).
 */
using System;
class QuadraEquation
{
    static void Main(string[] args)
    {
        Console.Write("Enter the first coefficient: a=:");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second coefficient: b=:");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third coefficient: c=:");
        double c = double.Parse(Console.ReadLine());
        Console.WriteLine("Our equation is: {0}*(x*x) + ({1}*x) + {2}",a,b,c); // x2 = Math.Pow(x,2)
        double discriminant = (Math.Pow(b, 2) - (4 * a * c));
        Console.WriteLine("Disciminant = b*b - 4*a*c = {0}",discriminant); // b2 = Math.Pow(b,2)
        Console.WriteLine("Sqrt discriminant = {0}", Math.Sqrt(discriminant));
        double x1 = ((-b) + Math.Sqrt(discriminant))/(2*a);
        double x2 = ((-b) - Math.Sqrt(discriminant))/(2*a);
        Console.WriteLine("x1 = -b + sqrt(discirminant)/(2*a)= "+ x1);
        Console.WriteLine("x2 = -b - sqrt(discirminant)/(2*a)= " + x2);
    }
}

