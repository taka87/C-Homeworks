using System;

class Exercise
{
    static void Main()
    {
        string[] array1 = Console.ReadLine().Split();
        string[] array2 = Console.ReadLine().Split();

        int lenght = Math.Min(array1.Length, array2.Length);
        int counter = 0;

        for (int i = 0; i < array1.Length; i++)
        {
            if (array1[i]==array2[i])
            {
                counter++;
            }
        }
        Console.WriteLine(counter);
    }
}