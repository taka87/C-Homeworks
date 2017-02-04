using System;
using System.Text;

namespace _06Password
{
    class Password
    {
        private const string CapitalLetters = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";

        private const string SmallLetters = "abcdefghijklmnopqrstuvwxyz";

        private const string Digits = "0123456789";

        private const string Symbol = "~!@#$%^&*()_+=`{}[]\\|':;.,/?<>";

        private const string AllChars = CapitalLetters + SmallLetters + Digits + Symbol;

        private static Random rnd = new Random();

        static void Main()
        {
            StringBuilder password = new StringBuilder();

            //generate capital letters
            for (int i = 1; i < 3; i++)
            {
                char capitalLetters = GenerateChar(CapitalLetters);
                InsertAtRandomPosition(password, capitalLetters);
            }
            // Generate two random small letters

            for (int i = 1; i <= 2; i++)
            {
                char smallLetter = GenerateChar(SmallLetters);
                InsertAtRandomPosition(password, smallLetter);
            }
            // Generate one random digit

            char digit = GenerateChar(Digits);
            InsertAtRandomPosition(password, digit);

            // Generate 3 special characters
            for (int i = 1; i <= 3; i++)
            {
                char specialChar = GenerateChar(Symbol);
                InsertAtRandomPosition(password, specialChar);
            }

            // Generate few random characters (between 0 and 7)
            int count = rnd.Next(8);
            for (int i = 1; i <= count; i++)
            {
                char specialChar = GenerateChar(AllChars);
                InsertAtRandomPosition(password, specialChar);
            }

            Console.WriteLine(password);
        }
        private static void InsertAtRandomPosition(StringBuilder password, char character)
        {
            int randomPoistion = rnd.Next(password.Length + 1);
            password.Insert(randomPoistion, character);
        }
        private static char GenerateChar(string availiableChars)
        {
            int randomIndex = rnd.Next(availiableChars.Length);
            char randomChar = availiableChars[randomIndex];
            return randomChar;
        }
    }
}