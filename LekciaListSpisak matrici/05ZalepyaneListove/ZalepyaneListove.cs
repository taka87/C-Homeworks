using System;
using System.Collections.Generic;
using System.Linq;

class ZalepyaneListove
{
    static void Main()
    {
        // 7 | 4  5 | 1 0 | 2 5 | 3
        string input = Console.ReadLine();
        string[] inputParts = input.Split('|');

        //Console.WriteLine(String.Join("\n", inputParts));

        inputParts = inputParts.Reverse().ToArray();
        
        //Console.WriteLine(String.Join("\n", inputParts));

        for (int i = 0; i < inputParts.Length; i++)
        {
            List<int> partNums = inputParts[i]
                .Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries) // RemoveEntryEmptyes e mn vajno !!!!!
                .Select(int.Parse)
                .ToList();

            Console.Write(string.Join(" ", partNums)+" ");
        }
    }
}