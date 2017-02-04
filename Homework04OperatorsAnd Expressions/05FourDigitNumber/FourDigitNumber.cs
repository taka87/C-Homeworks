using System;

class FourDigitNumber
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int first = n % 10;

        int second = n / 10;
        int secondNumber = second % 10;

        int third = n / 100;
        int thirdNumber = third % 10;

        int fourth = n / 1000;
        int fourthNumber = fourth % 10;

        //Console.WriteLine("{0}, {1}, {2}, {3}", first, second, third, fourth);
       // Console.WriteLine("{0}, {1}, {2}, {3}", first, secondNumber, thirdNumber, fourthNumber);
        Console.WriteLine(first+ secondNumber+ thirdNumber+ fourthNumber);
        Console.WriteLine("{0}{1}{2}{3}", first, secondNumber, thirdNumber, fourthNumber);
        Console.WriteLine("{0}{3}{2}{1}", first, secondNumber, thirdNumber, fourthNumber);
        Console.WriteLine("{3}{1}{2}{0}", first, secondNumber, thirdNumber, fourthNumber);
    }
}

