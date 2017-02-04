using System;

namespace _07SplitOptions
{
    class SplitOptions
    {
        static void Main(string[] args)
        {
            string arrList = "Amstel, Zagorka, Tuborg, Becks";

            char[] separators = new char[] { ' ', '.', ',' };

            string[] newArr = arrList.Split(separators);  //split -> razdelq gi po opredelen simvol daden masiv

            foreach (var item in newArr)
            {
                Console.Write(item);
            }
            Console.WriteLine();

            foreach (string beer in newArr)
            {
                if (beer != "")
                {
                    Console.WriteLine(beer);
                }
            }

            newArr = arrList.Split(separators, StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine();
            foreach (var item in newArr)
            {
                Console.WriteLine(item);
            }
        }
    }
}