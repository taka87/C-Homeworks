﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace _06.Reverse_Words_in_Sentence
{
    class ReverceWordInSentence
    {
        static void Main()
        {
            string text = Console.ReadLine();
            char[] separators = { '.', ',', ':', ';', '=', '(', ')', '&', '[', ']', '\"', '\'', '\\', '/', '!', '?', ' ' };

            List<string> list = text.Split(separators, StringSplitOptions.RemoveEmptyEntries).ToList();

            list.Reverse();

            List<string> tempList = new List<string>(list);

            tempList.Sort((e1, e2) => e2.Length.CompareTo(e1.Length));

            List<string> sep = text.Split(tempList.ToArray(), StringSplitOptions.RemoveEmptyEntries).ToList();

            for (int i = 0; i < list.Count; i++)
            {
                Console.Write(list[i] + sep[i]);
            }
        }
    }
}