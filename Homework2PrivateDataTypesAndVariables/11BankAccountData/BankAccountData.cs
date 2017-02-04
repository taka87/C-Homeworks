using System;

class BankAccountData
{
    static void Main()
    {
        Console.Write("Enter first name : ");
        string firstName = Console.ReadLine();
        Console.Write("Enter middle name : ");
        string middleName = Console.ReadLine();
        Console.Write("Enter last name : ");
        string lastName = Console.ReadLine();
        Console.Write("Enter balance of account: ");
        int balance = int.Parse(Console.ReadLine());
        Console.Write("Enter bank name : ");
        string bankName = Console.ReadLine();
        Console.Write("Enter IBAN account : ");
        string iBAN = Console.ReadLine();
        Console.Write("Enter number of first credit card account : ");
        string firstCreditCard = Console.ReadLine();
        Console.Write("Enter number of second credit card account : ");
        string secondCreditCard = Console.ReadLine();
        Console.Write("Enter number of third credit card account : ");
        string thirdCreditCard = Console.ReadLine();
        Console.WriteLine();
        Console.WriteLine("first name:{0}", firstName);
        Console.WriteLine("middle name:{0}", middleName);
        Console.WriteLine("last name:{0}", lastName);
        Console.WriteLine("balance:{0}", balance);
        Console.WriteLine("bank name:{0}", bankName);
        Console.WriteLine("IBAN: {0}", iBAN);
        Console.WriteLine("first credit card:{0}", firstCreditCard);
        Console.WriteLine("second credit card:{0}", secondCreditCard);
        Console.WriteLine("third credit card:{0}", thirdCreditCard);
    }
}

