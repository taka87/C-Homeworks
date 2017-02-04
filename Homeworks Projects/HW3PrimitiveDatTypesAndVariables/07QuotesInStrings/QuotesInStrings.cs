using System;

class QuotesInStrings
{
    static void Main()
    {
        string str = "The \"use\" of quotations causes difficulties.";
        string secondStr = @"The ""use"" of quotations causes difficulties.";

        Console.WriteLine(str);
        Console.WriteLine(secondStr);
    }
}