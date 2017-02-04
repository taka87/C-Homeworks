using System;

class StringsAndObjects
{
    static void Main()
    {
        string greeting = "Hello";
        string word = "World!";

        object concat1 = greeting + " " + word;
        string concat2 = (string)concat1;

        Console.WriteLine(concat1);
        Console.WriteLine(concat2);
    }
}

