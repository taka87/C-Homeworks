using System;

class LastKNumbersSum
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int k = int.Parse(Console.ReadLine());

        long[] arr = new long[n];
        arr[0] = 1;

        for (int current = 0; current < arr.Length; current++)
        {
            int start = Math.Max(0, current - k);
            int end = current - 1;
            long sum = arr[current];//sum the values of seq[start...end]


            for (int j = start; j <= end; j++)
            {
                sum += arr[j];
            }
            arr[current] = sum;
        }

        for (int i = 0; i < arr.Length; i++)
        {
            Console.WriteLine(arr[i] + " ");
        }
    }
}