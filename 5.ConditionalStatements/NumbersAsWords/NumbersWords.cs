/*      Problem 11.* Number as Words

    Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation.
 Examples:

numbers	number as words
0 Zero
9 Nine
10 Ten
12 Twelve
19 Nineteen
25 Twenty five
98 Ninety eight
98 Ninety eight
273	Two hundred and seventy three
400	Four hundred
501	Five hundred and one
617	Six hundred and seventeen
711	Seven hundred and eleven
999	Nine hundred and ninety nine
 */
using System;
class NumbersWords
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number in the interval [0-999]: ");
        int number = int.Parse(Console.ReadLine());

        int hundredDigit = ((number / 100) % 10);
        int decimalDigit = ((number / 10) % 10);
        int digit = (number % 10);
        string numStr = "";

        switch (hundredDigit)
        {
            case 1:
                numStr = "One Hundred";
                break;
            case 2:
                numStr = "Two Hundred";
                break;
            case 3:
                numStr = "Three Hundred";
                break;
            case 4:
                numStr = "Four Hundred";
                break;
            case 5:
                numStr = "Five Hundred";
                break;
            case 6:
                numStr = "Six Hundred";
                break;
            case 7:
                numStr = "Seven Hundred";
                break;
            case 8:
                numStr = "Eight Hundred";
                break;
            case 9:
                numStr = "Nine Hundred";
                break;
            default:
                break;
        }
        if ((hundredDigit!=0) && ((decimalDigit!=0) || (digit!=0)))
        {
            numStr += " and ";
        }

        switch(decimalDigit)
        {
            case 2:
                numStr += "Twenty ";
                break;
            case 3:
                numStr += "Thirty ";
                break;
            case 4:
                numStr += "Fourty ";
                break;
            case 5:
                numStr += "Fifty ";
                break;
            case 6:
                numStr += "Sixty ";
                break;
            case 7:
                numStr += "Seventy ";
                break;
            case 8:
                numStr += "Eighty ";
                break;
            case 9:
                numStr += "Ninety ";
                break;
            default:
                break;
        }

        if (decimalDigit !=1)
        {
            switch (digit)
            {
                case 1:
                    numStr += "One";
                    break;
                case 2:
                    numStr += "Two";
                    break;
                case 3:
                    numStr += "Three";
                    break;
                case 4:
                    numStr += "Four";
                    break;
                case 5:
                    numStr += "Five";
                    break;
                case 6:
                    numStr += "Six";
                    break;
                case 7:
                    numStr += "Seven";
                    break;
                case 8:
                    numStr += "Eight";
                    break;
                case 9:
                    numStr += "Nine";
                    break;
                default:
                    break;
            }
        }
        else
        {
            switch (digit)
            {
                case 0:
                    numStr += "Ten";
                    break;
                case 1:
                    numStr += "Eleven";
                    break;
                case 2:
                    numStr += "Twelve";
                    break;
                case 3:
                    numStr += "Thirteen";
                    break;
                case 4:
                    numStr += "Fourteen";
                    break;
                case 5:
                    numStr += "Fifteen";
                    break;
                case 6:
                    numStr += "Sixteen";
                    break;
                case 7:
                    numStr += "Seventeen";
                    break;
                case 8:
                    numStr += "Eigteen";
                    break;
                case 9:
                    numStr += "Nineteen";
                    break;
                default:
                    break;
            }
        }
        if (number ==0)
        {
            numStr += "Zero";
        }
        Console.WriteLine("Number as words is: {0}",numStr);
    }
}

