using System;

class Holiday
{
    static void Main()
    {
        double money = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();

        double result = 0;

        if (money <= 100)  // nqkade v BG
        {
            if (season == "summer")
            {
                result = (30 * money) / 100;
                Console.WriteLine("Somewhere in Bulgaria\nCamp - {0:0.00}", result);
            }
            else if (season == "winter")
            {
                result = (70 * money) / 100;
                Console.WriteLine("Somewhere in Bulgaria\nHotel - {0:0.00}", result);
            }
        }
        else if (money <= 1000 && money > 100)  // nqkade v balkanite
        {
            if (season == "summer")
            {
                result = (40 * money) / 100;
                Console.WriteLine("Somewhere in Balkans\nCamp - {0:0.00}", result);
            }
            else if (season == "winter")
            {
                result = (80 * money) / 100;
                Console.WriteLine("Somewhere in Balkans\nHotel - {0:0.00}", result);

            }
        }
        else if (money > 1000)  // nqkade v Evropa
        {
            result = (90 * money) / 100;
            Console.WriteLine("Somewhere in Europe\nHotel - {0:0.00}", result);

        }
    }
}