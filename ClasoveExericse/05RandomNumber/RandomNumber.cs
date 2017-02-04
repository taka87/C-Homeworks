using System;
class RandomNumber
{
    static void Main()
    {
        Random num = new Random();

        for (int i = 0; i < 6; i++)
        {
            int randomNumber = num.Next(49) + 1;
            Console.WriteLine(randomNumber);
        }


        for (int i = 0; i < 6; i++)
        {
            Console.WriteLine(num.Next(100) + 1);
        }
    }
}