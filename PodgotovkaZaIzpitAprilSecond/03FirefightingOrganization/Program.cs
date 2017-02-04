using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int kids = 0;
        int adults = 0;
        int seniors = 0;

        while (true)
        {
            int num = n;

            char[] input = Console.ReadLine().ToCharArray();

            if (input[0] == 'r')
            {
                break;
            }

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'K' && num > 0)
                {
                    kids++;
                    num--;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'A' && num > 0)
                {
                    adults++;
                    num--;
                }
            }
            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == 'S' && num > 0)
                {
                    seniors++;
                    num--;
                }
            }
           
        }
        Console.WriteLine("Kids: {0}\nAdults: {1}\nSeniors: {2}", kids, adults, seniors);
    }
}