using System;
using System.Linq;

namespace _1.Largest_Common_End
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] arr1 = Console.ReadLine().Split(' ').ToArray();
            string[] arr2 = Console.ReadLine().Split(' ').ToArray();
            uint brl = 0;
            uint brr = 0;

            uint lenght = (uint)Math.Min(arr1.Length, arr2.Length);
            string resultl = "";
            string resultr = "";


            for (int i = 0; i < lenght; i++)
            {
                if (arr1[i] == arr2[i])
                {

                    resultl = resultl + arr1[i];
                    brl++;
                }
                else
                {
                    break;
                }
            }
            for (int i = 0; i < lenght; i++)
            {
                if (arr1[arr1.Length - 1 - i] == arr2[arr2.Length - 1 - i])
                {
                    resultr = resultr + arr1[arr1.Length - 1 - i];
                    brr++;
                }
                else
                {
                    break;
                }
            }
            if (brl == brr && brl == 0)
            {
                // Console.WriteLine("No common words at the left and right",brl);
                Console.WriteLine("0");
            }
            else if (brl >= brr)
            {
                //  Console.WriteLine($"The largest common end is at the left: {resultl} {brl}");
                Console.WriteLine(brl);
            }
            else
            {
                // Console.WriteLine($"The largest common end is at the right: {resultr} {brr}");
                Console.WriteLine(brr);
            }
        }
    }
}