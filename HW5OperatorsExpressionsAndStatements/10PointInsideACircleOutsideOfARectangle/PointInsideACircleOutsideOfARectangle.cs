using System;


class PointInACircle
{
    static void Main()
    {
        double x = double.Parse(Console.ReadLine());
        double y = double.Parse(Console.ReadLine());

        bool isInCircle = Math.Pow((x - 1), 2) + Math.Pow((y - 1), 2) <= Math.Pow(1.5, 2) && ((x <= 2.5) && (x >= -0.5)) && ((y <= 2.5) && (y > 1)); // parvata ->
        //->stoinost na stepen po vtorata stoiynostMath.Pow(1.5, 2) 1.5 - na vtora

        //bool outsiderectangle = (x >= -1 && x <= 5) && (y <= 6) && (y >= 2);

        if (isInCircle == true)
        {
            Console.WriteLine("Yes");
        }
        else
        {
            Console.WriteLine("no");
        }
    }
}
