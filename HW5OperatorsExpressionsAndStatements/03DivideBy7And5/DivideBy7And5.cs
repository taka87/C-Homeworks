using System;

class DivideBy7And5
{
    static void Main()
    {
        int n = Int32.Parse(Console.ReadLine());

        if ((n % 5 == 0) && (n % 7 == 0))
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}