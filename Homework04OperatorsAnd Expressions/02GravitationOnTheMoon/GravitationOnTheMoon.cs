using System;

class GravitationOnTheMoon
{
    static void Main()
    {
        float weight = float.Parse(Console.ReadLine());

        float weightMoon = (weight * 17) / 100;
        Console.WriteLine(weightMoon);
    }
}

