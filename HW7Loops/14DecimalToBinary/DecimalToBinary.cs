using System;

class DecimalToBinary
{
    static void Main()
    {
        int sum = 0;
        string calc = string.Empty;

        int n = int.Parse(Console.ReadLine());

        if (n != 0)
        {
            for (int i = 0; i < 64; i++)
            {
                if (n == 0)
                {
                    break;
                }
                int divider = n % 2;
                sum = n - divider;
                calc += Convert.ToString(divider);
                n = (int)(n / 2);
            }
            char[] arr = calc.ToCharArray();
            Array.Reverse(arr);
            Console.Write(arr);
            Console.WriteLine();
        }
        else
        {
            Console.WriteLine("0");
        }


        //for (int i = 13; i >= 0; i--)
        //{
        //    k = n >> i;
        //    if (Convert.ToBoolean(k & 1))
        //    {
        //        Console.Write("1");
        //    }
        //    else
        //    {
        //        Console.Write("0");
        //    }
        //}
        //Console.WriteLine();
        // Console.ReadKey();
    }
}