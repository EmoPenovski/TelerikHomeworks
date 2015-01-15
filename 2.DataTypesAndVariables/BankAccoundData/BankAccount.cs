/*      Problem 11. Bank Account Data

    A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
    Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.
*/
using System;

class BankAccount
{
    static void Main(string[] args)
    {
        string firstName = "Luke";
        string middleName = "Veidarov";
        string lastName = "Skywalker";
        decimal balance = 8445.25M;
        string bankName = "NoIdeaBank";
        string iBan = "2045452345672355157554";
        ulong firstCardNumber = 1234567890123456;
        ulong secondCardNumber = 6543210987654321;
        ulong thirdCardNumber = 3587183571095075;
        Console.WriteLine("Bank Account of {0} {1}:",firstName,lastName);
        Console.WriteLine("Your balance is: {0}lv.\nBank Name: {1}\nYour IBAN: \"{2}\"\nCredit Card Numbers:\nFirst Card Number:\"{3}\"\nSecond Card Number:\"{4}\"\nThird Card Number:\"{5}\"", balance, bankName, iBan, firstCardNumber, secondCardNumber, thirdCardNumber);
    }
}

