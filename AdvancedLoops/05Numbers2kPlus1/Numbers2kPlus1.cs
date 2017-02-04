    using System;

    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());

            int num = 1;

            for (int i = 0; i <= n; i++)
            {
                if (num <= n)
                {
                    Console.WriteLine(num);
                    num = num * 2 + 1;
                
                }
            }
        }
    }