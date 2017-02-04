using System;
using System.Linq;

class LargestCommonEnd
{
    static void Main()
    {
        string[] firstStr = Console.ReadLine().Split(' ').ToArray();
        string[] secondtStr = Console.ReadLine().Split(' ').ToArray();

        //int count = 1;

        //for (int i = 0; i < firstStr.Length; i++)
        //{
        //    Console.WriteLine(PrintRights(firstStr, secondtStr));
        //}

        //if (firstStr.Length < secondtStr.Length)
        //{
        //    count = secondtStr.Length;
        //}
        //else
        //{
        //    count = firstStr.Length;
        //}

        //string[] newStr = new string[count];

        //for (int i = 0; i < firstStr.Length && i < secondtStr.Length; i++)
        //{
        //    //for (int j = 0; j < secondtStr.Length; j++,count++)
        //    //{
        //    if (firstStr[firstStr.Length - count] == secondtStr[secondtStr.Length - count])
        //    {
        //        newStr[i] = firstStr[i];
        //        count++;
        //    }
        //    //}
        //}
        //for (int i = 0; i < count; i++)
        //{
        //    Console.Write(newStr[count] + " ");
        //}
        Console.WriteLine(PrintRights(firstStr, secondtStr));
    }

    private static int PrintRights(string[] firstStr, string[] secondtStr)
    {
        int rightCount = 0;
        while (rightCount < secondtStr.Length && rightCount < secondtStr.Length)
        {
            if (firstStr[firstStr.Length - rightCount - 1] == secondtStr[secondtStr.Length - rightCount - 1])
            {
                rightCount++;
            }

            else
            {
                break;
            }
        }
        return rightCount;
    }
}