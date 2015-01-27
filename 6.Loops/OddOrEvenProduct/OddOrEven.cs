/*      Problem 10. Odd and Even Product

    You are given n integers (given in a single line, separated by a space).
    Write a program that checks whether the product of the odd elements is equal to the product of the even elements.
    Elements are counted from 1 to n, so the first element is odd, the second is even, etc.
 */
using System;
class OddOrEven
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter n integers (given in a single line, separated by a space): ");
        string[] oddOrEven = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
        bool checkProduct = true;
        int evenNumbers=1;
        int oddNumbers=1;
        for (int i = 0; i < oddOrEven.Length; i=i+2)
        {
            evenNumbers *= int.Parse(oddOrEven[i]);
        }
        for (int i = 1; i < oddOrEven.Length; i=i+2)
        {
            oddNumbers *= int.Parse(oddOrEven[i]);
        }
        if (evenNumbers==oddNumbers)
        {
            Console.WriteLine(checkProduct);
        }
        else
        {
            Console.WriteLine(!checkProduct);
            Console.WriteLine("Odd_product={0}",oddNumbers);
            Console.WriteLine("Even_product={0}",evenNumbers);
        }
    }
}

