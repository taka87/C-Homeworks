using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercisesInClass

{
    public class Exercise
    {
        static void Main()
        {
            List<string> lis = new List<string> { "1", "2", "3", "4", "5" };

            Console.WriteLine(string.Join(" ", lis));

            lis = lis.OrderBy(a => a).ThenBy(a =>a).ToList();

        }
    }
}