using System;

class Environment
{
    //public static int TickCount { get; }

    static void Main()
    {
        int sum = 0;
        int startTime = System.Environment.TickCount;
        //int startTime = Environment.TickCount;

        for (int i = 0; i < 10000000; i++)
        {
            sum++;
        }

        int endTime = System.Environment.TickCount;
        Console.WriteLine("The time elapsed is {0} sec", (endTime-startTime)/1000.0);
    }
}