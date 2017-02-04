using System;

class Exercise
{
    static void Main()
    {
        string text = "Pesho e mnogo gotyan!";

        //text[0] = "G"; ne raboti zashtoto texta ne moje da se printira

        text = "Super!";
        Console.WriteLine(text);
        Console.WriteLine(text[0]);

        PrintAllChar(text);
    }

    public static void PrintAllChar(string text)
    {
        for (int i = 0; i < text.Length; i++)
        {
            Console.WriteLine(text[i]);
        }
    }
}