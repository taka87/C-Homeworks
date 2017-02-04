using System;

class ComparingFloats
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double c = Math.Round(a, 6); //zakraglyame go do 6-ta cifra sled zapetayata
        double b = double.Parse(Console.ReadLine());
        double d = Math.Round(b, 6);

        if (c == d)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}