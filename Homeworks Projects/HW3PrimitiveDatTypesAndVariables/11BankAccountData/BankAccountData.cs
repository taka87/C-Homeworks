using System;

    class BankAccountData
    {
        static void Main()
        {
            //A bank account has a holder name (first name, middle
            //    name and last name), available amount of money (balance),
            //        bank name, IBAN, 3 credit card numbers associated with the account.
            //            Declare the variables needed to keep the information for a single 
            //                bank account using the appropriate data types and descriptive names.
            Console.Write("Please input first name : ");
            string firstName = Console.ReadLine();

            Console.Write("Please input middle name : ");
            string middleName = Console.ReadLine();

            Console.Write("Please input last name : ");
            string lastName = Console.ReadLine();

            Console.Write("Please input balance in your bank account : ");
            decimal balance = decimal.Parse(Console.ReadLine());

            Console.Write("Please you bank name : ");
            string bankName = Console.ReadLine();

            Console.Write("Please input iBan : ");
            string iban = Console.ReadLine();

            Console.Write("Please input your 3 credit card numbers divided by \"Enter\": ");
            long firstCreditC = long.Parse(Console.ReadLine());
            long secondCreditC = long.Parse(Console.ReadLine());
            long thirdCreditC = long.Parse(Console.ReadLine());

            Console.WriteLine("Banc account holder is : {0} {1} {2}", firstName, middleName, lastName);
            Console.WriteLine("Availiable money in bank account is : {0}",balance);
            Console.WriteLine("Bank name is : {0}", bankName);
            Console.WriteLine("Iban is : {0}", iban);
            Console.WriteLine("First credit card number is : {0}", firstCreditC);
            Console.WriteLine("Second credit card number is : {0}", secondCreditC);
            Console.WriteLine("FiThird credit card number is : {0}", thirdCreditC);
        }
    }