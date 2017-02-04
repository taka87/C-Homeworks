using System;
using System.Linq;

class DistanceBetweePoints
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();


        double x1 = input[0];
        double y1 = input[1];
        double x2 = input1[0];
        double y2 = input1[1];

        Console.WriteLine(CalcDistance(x1, y1, x2, y2));
    }

    private static double CalcDistance(double x1, double y1, double x2, double y2)
    {
        double c = 0;

        c = Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2);

        return (Math.Sqrt(c));
    }
}