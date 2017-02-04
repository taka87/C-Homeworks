using System;
using System.Linq;

public class SequenceOfCommands_broken
{
    //private const char ArgumentsDelimiter = ' ';

    public static void Main()
    {
        int sizeOfArray = int.Parse(Console.ReadLine());

        long[] array = Console.ReadLine()
            .Split()
            .Select(long.Parse)
            .ToArray();

        string action = Console.ReadLine();
        //string comman = comman.Split().toa
        string[] command = action.Split();

        while (!command[0].Equals("stop"))
        {

            //string line = Console.ReadLine().Trim();
            int[] args = new int[2];

            if (command[0].Equals("add") || command[0].Equals("subtract") || command[0].Equals("multiply"))
            {

                args[0] = int.Parse(command[1]);
                args[0] -= 1;
                args[1] = int.Parse(command[2]);
                //args[1] -= 1;

                //PerformAction(array, command[0], args);
            }

            //PerformAction(array, command[0], args);

            //Console.WriteLine("");

            array = PerformAction(array, command[0], args);
            PrintArray(array);

            action = Console.ReadLine();
            command = action.Split();


        }
    }
    //array za promqna , comandata , argumenti za promqna
    static long[] PerformAction(long[] arr, string action, int[] args)
    {
        long[] array = arr.Clone() as long[];  // pravi kopie na sushtiq array
        int pos = args[0];
        int value = args[1];

        switch (action)
        {
            case "multiply":
                array[pos] = array[pos] * value;
                break;
            case "add":
                array[pos] = array[pos] + value;
                break;
            case "subtract":
                array[pos] = array[pos] - value;
                break;
            case "lshift":
                ArrayShiftLeft(array);
                break;
            case "rshift":
                ArrayShiftRight(array);
                break;
        }

        return array;
    }

    private static void ArrayShiftRight(long[] array)
    {
        long lastElement = array[0];
        long last = array[array.Length - 1];

        for (int i = array.Length - 1; i >= 0; i--)
        {
            if (i > 1)
            {
                array[i] = array[i - 1];
            }
            else if(i==1)
            {
                array[i] = lastElement;
            }
            else
            {
                array[i] = last;
            }
        }
    }

    private static void ArrayShiftLeft(long[] array)
    {
        long firstElement = array[0];

        for (int i = 0; i < array.Length; i++)
        {
            if (i != array.Length - 1)
            {
                array[i] = array[i + 1];
            }
            else
            {
                array[i] = firstElement;
            }
        }
    }

    private static void PrintArray(long[] array)
    {
        for (int i = 0; i < array.Length; i++)
        {
            Console.Write(array[i] + " ");
        }
        Console.WriteLine();
    }
}