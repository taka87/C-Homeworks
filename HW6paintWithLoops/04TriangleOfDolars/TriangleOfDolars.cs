using System;

class rectanglesOf10Stars
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        char ch = '$';
       // Console.WriteLine(ch);
        for (int i = 1; i <= n; i++)
        {
            for (int j = 0; j < i; j++)
            {
                Console.Write(ch+" ");
            }
            Console.WriteLine();
        }
    }
}