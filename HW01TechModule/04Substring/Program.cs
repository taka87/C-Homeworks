﻿using System;

public class Substring_broken
{
    public static void Main()
    {
        string text = Console.ReadLine();
        int jump = int.Parse(Console.ReadLine());
        //jump += 1;

        //const char Search = 'р';

        bool hasMatch = false;

        for (int i = 0; i < text.Length; i++)
        {
            //if (text[i] == Search)  // zashto ne raboti ?
            if (text[i] == 'p')
            {
                hasMatch = true;

                int endIndex = jump+1;

                if (endIndex > text.Length - i)
                {
                    endIndex = text.Length - i;
                }

                string matchedString = text.Substring(i, endIndex);
                Console.WriteLine(matchedString);
                i +=jump;
            }
        }

        if (!hasMatch)
        {
            Console.WriteLine("no");
        }
    }
}
