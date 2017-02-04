using System;

class Animals
{
    static void Main()
    {
        string str = Console.ReadLine();

        switch (str)
        {
            case "dog":
                Console.WriteLine("mammal");
                break;
            case "crocodile":
            case "tortoise":
            case "snake":
                Console.WriteLine("reptile");
                break;
            default:
                Console.WriteLine("unknown");
                break;
        }
    }
}