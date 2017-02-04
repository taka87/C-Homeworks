using System;

class TriplesOfLetters
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        
        for (int i = 0; i < n; i++)
        {
            for (int j = 0; j < n; j++)
            {
                for (int k = 0; k < n; k++)
                {
                    char ch1 = (char)('a'+i);
                    char ch2 = (char)('a'+j);
                    char ch3 = (char)('a'+k);
                    Console.WriteLine("{0}{1}{2}", ch1,ch2,ch3);
                }
            }
        }
        Console.WriteLine();
    }
}