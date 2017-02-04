using System;

class NumberAsWords
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());

        int first = (a % 1000) / 100;
        int second = (a % 100) / 10;
        int third = a % 10;

        //Console.WriteLine("{0} {1} {2}", first, second, third);

        if (a >= 0 && a <= 999)
        {
            switch (first)
            {
                case 1:
                    Console.Write("one hundret ");
                    break;
                case 3:
                    Console.Write("two hundret ");
                    break;
                case 4:
                    Console.Write("four hundret ");
                    break;
                case 5:
                    Console.Write("five hundret ");
                    break;
                case 6:
                    Console.Write("six hundret ");
                    break;
                case 7:
                    Console.Write("seven hundret ");
                    break;
                case 8:
                    Console.Write("eight hundret ");
                    break;
                case 9:
                    Console.Write("nine hundret ");
                    break;
            }
            switch (second)
            {
                case 2:
                    Console.Write("twenty ");
                    break;
                case 3:
                    Console.Write("thirty ");
                    break;
                case 4:
                    Console.Write("forty ");
                    break;
                case 5:
                    Console.Write("fifty ");
                    break;
                case 6:
                    Console.Write("sixty ");
                    break;
                case 7:
                    Console.Write("seventy ");
                    break;
                case 8:
                    Console.Write("eighty ");
                    break;
                case 9:
                    Console.Write("ninety ");
                    break;
            }
            if (second != 1)
            {
                switch (third)
                {
                    case 1:
                        Console.WriteLine("one");
                        break;
                    case 2:
                        Console.WriteLine("two");
                        break;
                    case 3:
                        Console.WriteLine("thre");
                        break;
                    case 4:
                        Console.WriteLine("four");
                        break;
                    case 5:
                        Console.WriteLine("five");
                        break;
                    case 6:
                        Console.WriteLine("six");
                        break;
                    case 7:
                        Console.WriteLine("seven");
                        break;
                    case 8:
                        Console.WriteLine("eight");
                        break;
                    case 9:
                        Console.WriteLine("nine");
                        break;
                }
            }
            else if (second == 1)
            {
                switch (second + 9 + third)
                {
                    case 10:
                        Console.WriteLine("ten");
                        break;
                    case 11:
                        Console.WriteLine("eleven");
                        break;
                    case 12:
                        Console.WriteLine("twelve");
                        break;
                    case 13:
                        Console.WriteLine("thirteen");
                        break;
                    case 14:
                        Console.WriteLine("fourteen");
                        break;
                    case 15:
                        Console.WriteLine("fifteen");
                        break;
                    case 16:
                        Console.WriteLine("sixteen");
                        break;
                    case 17:
                        Console.WriteLine("seventeen");
                        break;
                    case 18:
                        Console.WriteLine("eighteen");
                        break;
                    case 19:
                        Console.WriteLine("nineteen");
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}