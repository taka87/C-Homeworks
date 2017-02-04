using System;

class GreatestCommonDivisor
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        int m = int.Parse(Console.ReadLine());

        Console.WriteLine( Calculator(n, m) ); 
    }

  static int Calculator(int n, int m)
    {
        int num = 0;

        while (m!=0)
        {
            num = m;
            m = n % m;
            n = num;              
        }
        return n;
    }
}