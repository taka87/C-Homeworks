using System;

class SumDigiits
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int sum = 0;

        for (int i = 12; i > 0; i--)
        {
            //cikala se varti do 12 za da hvane chislo dalgo do 12 simvola 
            sum += n % 10;
            n /= 10;
        }
        //long num3 = n / 100000000 % 10;
        //long num2 = n / 10000000 % 10;
        //long num1 = n / 1000000 % 10;
        //long num = n / 100000 % 10;
        //long zero = n / 10000 % 10;
        //long first = n / 1000 % 10;
        //long second = n / 100 % 10;
        //long third = n / 10 % 10;
        //long fourth = n / 1 % 10;

        //int sum = (int)(num3 + num2 + num1 + num + zero + first + second + third + fourth);

        Console.WriteLine(sum);
    }
}