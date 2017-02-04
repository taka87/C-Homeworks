using System;
using System.Linq;

class Program
{
    //tva neche da raboti
    static void Main()
    {
        int[] days = Console.ReadLine().Split().Select(int.Parse).ToArray(); ;

        PrintArray(days);
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