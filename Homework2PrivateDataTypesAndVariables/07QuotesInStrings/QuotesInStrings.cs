using System;

class QuotesInStrings
{
    static void Main()
    {
        string variable = "\"use\"";

        Console.WriteLine("The {0} of quotations causes difficulties.", variable);
        Console.WriteLine("The " + variable + " of quotations causes difficulties.");

        Console.WriteLine("The \"use\" of quotations causes difficulties.");
        Console.WriteLine(@"The ""use"" of quotations causes difficulties.");
    }
}

