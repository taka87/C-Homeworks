using System;

class Program
{
    static void Main(string[] args)
    {
        string neshtoSi = "Peshoto";

        string RemovedLetter = neshtoSi.Remove(0, 3);
        string RemovedString = neshtoSi.Replace('h', 'M');
        string substring = neshtoSi.Substring(0, 4);

        Console.WriteLine(substring);
        Console.WriteLine(RemovedString);
        Console.WriteLine(RemovedLetter);
    }
}
