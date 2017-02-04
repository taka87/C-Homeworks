using System;

class ThirdDigitIs7
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        //  if (myInt.ToString().Length >= 3 && myInt.ToString()[2] == '5')
        //int result = (n / 100) % 10;
        int result = (n % 1000) / 100 ;

        if (result == 7)
        {
            Console.WriteLine(true);
        }
        else
        {
            Console.WriteLine(false);
        }
    }
}