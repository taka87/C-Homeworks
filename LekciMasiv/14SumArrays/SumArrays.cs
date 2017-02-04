using System;
using System.Linq;

class SumArrays
{
    static void Main()
    {
        int[] arr1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int[] arr2 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        CalculateSumArr(arr1, arr2);

        // BEZ METOD !!

        //int n = Math.Max(arr1.Length, arr2.Length);

        //int[] sumArr = new int[n];

        //for (int i = 0; i < n; i++)
        //{
        //    sumArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
        //}
        //Console.WriteLine(string.Join(" ", sumArr));
    }

    private static void CalculateSumArr(int[] arr1, int[] arr2)
    {
        int n = Math.Max(arr1.Length, arr2.Length);

        int[] sumArr = new int[n];

        for (int i = 0; i < n; i++)
        {
            //V tozi red pri vsqko izvartane na cikala na vseki element ot otdelnite elementi cifrichkata na cikala
            //-> se %-va i v zavisimost ot tova prevarta nalichnite simvoli ako gi nqma v sledvashtite redove
            sumArr[i] = arr1[i % arr1.Length] + arr2[i % arr2.Length];
        }

        // string.Join Sabira masiva na edin red razdelya go s whitespace za da moje da go otpechata na edin red
        Console.WriteLine(string.Join(" ", sumArr));
    }
}