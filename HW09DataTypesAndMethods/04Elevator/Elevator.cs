﻿using System;

class Elevator
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int p = int.Parse(Console.ReadLine());

        int elevator = (int)Math.Ceiling((double)n / p);
        Console.WriteLine(elevator);
    }
}
