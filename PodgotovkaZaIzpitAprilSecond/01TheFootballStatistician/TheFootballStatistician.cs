using System;
using System.Collections.Generic;
using System.Linq;

class TheFootballStatistician
{
    static void Main()
    {
        decimal priceInput = decimal.Parse(Console.ReadLine());

        int arsenal = 0;
        int chelsea = 0;
        int everton = 0;
        int liverpool = 0;
        int manchesterCity = 0;
        int manchesterUnited = 0;
        int southampton = 0;
        int tottenham = 0;
        int matches = 0;

        while (true)
        {
            string[] input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            //input.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

            if (input[0] == "End")
            {
                break;
            }

            if (input[1] == "X")
            {
                switch (input[0])
                {
                    case "Arsenal":
                        arsenal++;
                        break;
                    case "Chelsea":
                        chelsea++;
                        break;
                    case "Everton":
                        everton++;
                        break;
                    case "Liverpool":
                        liverpool++;
                        break;
                    case "ManchesterCity":
                        manchesterCity++;
                        break;
                    case "ManchesterUnited":
                        manchesterUnited++;
                        break;
                    case "Southampton":
                        southampton++;
                        break;
                    case "Tottenham":
                        tottenham++;
                        break;
                    default:
                        break;
                }
                switch (input[2])
                {
                    case "Arsenal":
                        arsenal++;
                        break;
                    case "Chelsea":
                        chelsea++;
                        break;
                    case "Everton":
                        everton++;
                        break;
                    case "Liverpool":
                        liverpool++;
                        break;
                    case "ManchesterCity":
                        manchesterCity++;
                        break;
                    case "ManchesterUnited":
                        manchesterUnited++;
                        break;
                    case "Southampton":
                        southampton++;
                        break;
                    case "Tottenham":
                        tottenham++;
                        break;
                    default:
                        break;
                }
            }
            else if (input[1] == "1")
            {
                switch (input[0])
                {
                    case "Arsenal":
                        arsenal += 3;
                        break;
                    case "Chelsea":
                        chelsea += 3;
                        break;
                    case "Everton":
                        everton += 3;
                        break;
                    case "Liverpool":
                        liverpool += 3;
                        break;
                    case "ManchesterCity":
                        manchesterCity += 3;
                        break;
                    case "ManchesterUnited":
                        manchesterUnited += 3;
                        break;
                    case "Southampton":
                        southampton += 3;
                        break;
                    case "Tottenham":
                        tottenham += 3;
                        break;
                    default:
                        break;
                }
            }
            else
            {
                switch (input[2])
                {
                    case "Arsenal":
                        arsenal += 3;
                        break;
                    case "Chelsea":
                        chelsea += 3;
                        break;
                    case "Everton":
                        everton += 3;
                        break;
                    case "Liverpool":
                        liverpool += 3;
                        break;
                    case "ManchesterCity":
                        manchesterCity += 3;
                        break;
                    case "ManchesterUnited":
                        manchesterUnited += 3;
                        break;
                    case "Southampton":
                        southampton += 3;
                        break;
                    case "Tottenham":
                        tottenham += 3;
                        break;
                    default:
                        break;
                }
            }
            matches++;
        }

        decimal result = matches * priceInput * 1.94m;

        Console.WriteLine("{0:f2}lv.", result);
        Console.WriteLine("Arsenal - {0} points.", arsenal);
        Console.WriteLine("Chelsea - {0} points.", chelsea);
        Console.WriteLine("Everton - {0} points.", everton);
        Console.WriteLine("Liverpool - {0} points.", liverpool);
        Console.WriteLine("Manchester City - {0} points.", manchesterCity);
        Console.WriteLine("Manchester United - {0} points.", manchesterUnited);
        Console.WriteLine("Southampton - {0} points.", southampton);
        Console.WriteLine("Tottenham - {0} points.", tottenham);
    }
}