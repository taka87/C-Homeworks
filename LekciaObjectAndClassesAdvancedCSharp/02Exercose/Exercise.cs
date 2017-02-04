using System;
using System.Numerics;
using System.Net;

class Exercise
{
    static void Main()
    {
        BigInteger hugeNum = new BigInteger();

        hugeNum = 10000;

        for (int i = 0; i < 10000; i++)
        {
            hugeNum *= 2;
        }
        Console.WriteLine(decimal.MaxValue);
        Console.WriteLine(hugeNum);

        Console.WriteLine();
        Random rnd = new Random();
        int randomInt = rnd.Next(1, 1999);
        Console.WriteLine(randomInt);

        double cosinos = Math.Cos(Math.PI);
        Console.WriteLine(cosinos);
        int cosinoss = (int)Math.Cos(Math.PI);
        Console.WriteLine(cosinoss);

        WebClient webClient = new WebClient();
        webClient.DownloadFile("http://www.introprogramming.info/wp-content/uploads/2015/10/Intro-CSharp-Book-v2015.pdf", "book.pdf");
        //Process.Start("book.pdf");

        DateTime today = DateTime.Now;
        DateTime tomorrow = today.AddDays(1);
        Console.WriteLine(today);
        Console.WriteLine(tomorrow);
    }
}