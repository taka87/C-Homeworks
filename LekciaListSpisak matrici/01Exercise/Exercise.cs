using System;
using System.Collections.Generic;

class Exercise
{
    static void Main()
    {
        int[] arr = new int[4];
        string[] strArr = { "pesho", "gosho", "kuf" };
        List<int> listInt = new List<int>();
        List<string> listString = new List<string>();
        List<string> listStr = new List<string> { "gencho", "Pencho" };

        printListValues(listStr);
        listStr.Add("Goshko");
        printListValues(listStr);

        listStr.Insert(1, "Pavkata");
        printListValues(listStr);

        listStr.Remove("Pencho");   //.RemoveAll(e => e =='Gencho"); -> premahva vsichki elementi "Gencho" 
        printListValues(listStr);

        listStr.RemoveAt(2);        // premmahva vtori element nezavisimo kakuv e v lista
        printListValues(listStr);

        listStr.Insert(2, "Silvia");       
        printListValues(listStr);

        listStr[1] = "modifide";

        printListValues(listStr);

        listInt.Add(5); // list[0] -> 5
        listInt.Add(7); // list[1] -> 7

    }

    private static void printListValues(List<string> listStr)
    {
        for (int i = 0; i < listStr.Count; i++)
        {
            Console.WriteLine("{0} -> {1}", i, listStr[i]);
        }
        Console.WriteLine();
    }
}