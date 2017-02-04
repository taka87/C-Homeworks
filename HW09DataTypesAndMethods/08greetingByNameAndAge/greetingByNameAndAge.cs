using System;

class greetingByNameAndAge
{
    static void Main()
    {
        string firstName = Console.ReadLine();
        string lastName = Console.ReadLine();
        string ageString = Console.ReadLine();
        int age = int.Parse(ageString);

        Console.WriteLine($"Hello, {firstName} {lastName}.\r\nYou are {age} years old.");
    }
}