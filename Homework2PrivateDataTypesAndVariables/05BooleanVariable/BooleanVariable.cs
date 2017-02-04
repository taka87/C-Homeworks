using System;

class BooleanVariable
{
    static void Main()
    {
        Console.WriteLine("Is your gender Male or Female ? Yes or No?: ");
        string gender = Console.ReadLine();

        bool isFemale = gender == "Yes";
        Console.WriteLine("{0}", isFemale);
    }
}

