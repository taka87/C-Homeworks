using System;

class DailyCalorieIntake
{
    static void Main()
    {
        //        Men: BMR = 66.5 + (13.75 x weight in kg) +(5.003 x height in cm) – (6.755 x age in years)
        //Women: BMR = 655 + (9.563 x weight in kg) +(1.850 x height in cm) – (4.676 x age in years)

        int W = int.Parse(Console.ReadLine());
        int H = int.Parse(Console.ReadLine());
        int A = int.Parse(Console.ReadLine());
        string gender1 = Console.ReadLine();
        int E = int.Parse(Console.ReadLine());

        char gender = Convert.ToChar(gender1);
        double resultW = W / 2.2;
        double resultH = H * 2.54;

        //Console.WriteLine(resultW);
        //Console.WriteLine(resultH);

        double BMR = 0;
        double result = 0;

        if (gender == 'm')
        {
            BMR = 66.5 + (13.75 * resultW) + (5.003 * resultH) - (6.755 * A);
        }
        else
        {
            BMR = 655 + (9.563 * resultW) + (1.850 * resultH) - (4.676 * A);
        }
        //Console.WriteLine(BMR);

        if (E <= 0)
        {
            result = BMR * 1.2;
        }
        else if (E >= 1 && E <= 3)
        {
            result = BMR * 1.375;
        }
        else if (E >= 4 && E <= 6)
        {
            result = BMR * 1.55;
        }
        else if (E >= 7 && E <= 9)
        {
            result = BMR * 1.725;
        }
        else
        {
            result = BMR * 1.9;
        }
        Console.WriteLine(Math.Floor(result));
    }
}