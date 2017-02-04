using System;

class TriangleOdStars
{
    static void Main()
    {
       int num = int.Parse(Console.ReadLine());
                     //123456789 
        //string name = "ara";
        char star = '\u002A';

        for (int i = 1; i <= num; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(star);
            }
            Console.WriteLine();
        }
        // string name = "az sam Pesho"
        // name.Lenght

        //  i++
        //  i = i + 1
        //  i+=1
    }
}
