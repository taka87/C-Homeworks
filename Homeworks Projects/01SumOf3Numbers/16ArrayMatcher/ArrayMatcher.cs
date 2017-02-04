using System;

class ArrayMatcher
{
    static void Main()
    {
        string[] arrayData = Console.ReadLine().Split('\\');

        string firstArrey = arrayData[0];
        string secondtArrey = arrayData[1];
        string command = arrayData[2];
        string result = firstArrey;
        string finalResult = string.Empty;
        char[] arrResult = new char[firstArrey.Length > secondtArrey.Length ? secondtArrey.Length : firstArrey.Length];
        int index = 0;

        if (command == "join")
        {

            for (int i = 0; i < firstArrey.Length; i++)
            {
                for (int j = 0; j < secondtArrey.Length; j++)
                {
                    if (firstArrey[i] == secondtArrey[j])
                    {
                        arrResult[index] = firstArrey[i];
                        index++;
                    }
                }
            }
            Array.Sort(arrResult, StringComparer.Ordinal);
            finalResult = new string(arrResult);
            Console.WriteLine(finalResult);
        }
        if (command == "right exclude")
        {
            arrResult = new char[firstArrey.Length > secondtArrey.Length ? firstArrey.Length : secondtArrey.Length];
            for (int j = 0; j < secondtArrey.Length; j++)
            {
                for (int i = 0; i < secondtArrey.Length; i++)
                {
                    if (!(secondtArrey.Contains(((string)firstArrey[i].ToString()))))
                    {

                        arrResult[i] = firstArrey[i];
                    }
                }
            }
            Array.Sort(arrResult, StringComparer.Ordinal);
            finalResult = new string(arrResult);
            Console.WriteLine(finalResult);
        }
        if (command == "left exclude")
        {
            arrResult = new char[firstArrey.Length > secondtArrey.Length ? firstArrey.Length : secondtArrey.Length];

            for (int i = 0; i < firstArrey.Length; i++)
            {
                for (int j = 0; j < secondtArrey.Length; j++)
                {
                    if (!(firstArrey.Contains(((string)secondtArrey[i].ToString()))))
                    {
                        arrResult[i] = secondtArrey[i];
                    }
                }
            }
            Array.Sort(arrResult, StringComparer.Ordinal);
            finalResult = new string(arrResult);
            Console.WriteLine(finalResult);
        }

    }
}
