using System;

class Program
{
    static void Main()
    {
        //int[] days = new int[10];

        //for (int i = 0; i < days.Length; i++)
        //{
        //    days[i] = i + 1;
        //    Console.WriteLine(days[i]);
        //}

        //days = FillArray(days);
        //PrintArray(days);


        //System.Linq -> raboti pomoshtno na masivite

        string[] days =
        {
            "Monday",
            "Tuesday",
            "Wednesday"
        };

        int daysInput = int.Parse(Console.ReadLine());

        Console.WriteLine(days[daysInput-1]);
    }
    public static int[] FillArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            array[i] = int.Parse(Console.ReadLine());
        }
        return array;
    }
    public static void PrintArray(int[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.WriteLine(array[i]);
        }
    }
}