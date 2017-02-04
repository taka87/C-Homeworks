using System;
using System.Linq;

class MassiveReverse
{
    static void Main()
    {
        //int size = int.Parse(Console.ReadLine());

        string[] array = Console.ReadLine().Split();

        //for (int i = 0; i < size; i++)
        //{
        //    int num = int.Parse(Console.ReadLine());

        //    array[i] = num;

        //}

        for (int i = 0; i < array.Length / 2; i++)
        {
            string first = array[i];
            string end = array[array.Length - 1 - i];
            array[array.Length - 1 - i] = first;
            array[i] = end;

        }
        //Array.Reverse(array);

        Console.WriteLine(string.Join("\n", array));
    }
}