using System;

class StripedTowel
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());

        char one = '#';
        char second = '.';

        int counter = number;
        double row = Math.Floor(number * 1.5);

        int i = 0;

        for (int a = 0; a < row; a++)
        {
            for (int j = 0; j < counter; j++)
            {
                if ((counter + i) % 3 == 0)
                {
                    Console.Write(one);
                }
                else
                {
                    Console.Write(second);
                }
                i += 1;
            }
            Console.WriteLine();
        }
    }
}

