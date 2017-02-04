using System;

class CalculateNumbers
{
    static void Main()
    {
        double n = int.Parse(Console.ReadLine());

        int second = 0;
        int third = 0;
        int fourth = 0;

        double p1 = 0;
        double p2 = 0;
        double p3 = 0;

        for (int i = 0; i < n; i++)
        {
            int number = int.Parse(Console.ReadLine());

            if ((number % 2) == 0)
            {
                second++;
            }
            if ((number % 3) == 0)
            {
                third++;
            }
            if ((number % 4) == 0)
            {
                fourth++;
            }
        }

        p1 = (double)((second / n) * 100);
        p2 = (double)((third / n) * 100);
        p3 = (double)((fourth / n) * 100);

        Console.WriteLine("{0:0.00}%\n{1:0.00}%\n{2:0.00}%", p1, p2, p3);
    }
}
