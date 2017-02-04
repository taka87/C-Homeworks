using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        double weight = double.Parse(Console.ReadLine());

        double weightMoon = weight * 0.17;

        Console.WriteLine(weightMoon);
    }
}