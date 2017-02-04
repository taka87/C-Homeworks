using System;
using System.Collections.Generic;

class HexadecimalToDecimalNumber
{
    static void Main()
    {

        string hexaDecimal = Console.ReadLine();
        int num = 0;
        int hexNum = 0;
        long degree = hexaDecimal.Length - 1;

        for (int i = 0; i < hexaDecimal.Length; i++)
        {
            char ch = hexaDecimal[i];
            switch (ch.ToString())
            {
                case "A": 
                num = 10;
                break;
                case "B": 
                num = 11;
                break;
case "C": 
                num = 12;
                break;
case "D": 
                num = 13;
                break;
case "E": 
                num = 14;
                break;
case "F": 
                num = 15;
                break;
                default:
                num = Convert.ToInt32(ch.ToString());
                break;
            }
            hexNum += num * (long)Math.Pow(16, degree);
            degree--;
        }
        Console.WriteLine("{0}", hexNum);

        //static Dictionary<char, int> hexdecvalue = new Dictionary<char, int>
        //{
        //    {'0',0 },
        //    {'1',1 },
        //    {'2',2 },
        //    {'3',3 },
        //    {'4',4 },
        //    {'5',5 },
        //    {'6',6 },
        //    {'7',7 },
        //    {'8',8 },
        //    {'9',9 },
        //    {'a',10},
        //    {'b',11},
        //    {'c',12},
        //    {'d',13},
        //    {'e',14},
        //    {'f',15}
        //};
        //static decimal HexToDec(string hex)
        //{
        //    decimal result = 0;
        //    hex = hex.ToLower();

        //    for (int i = 0; i < hex.Length; i++)
        //    {
        //        char valAt = hex[hex.Length - 1 - i];
        //        result += hexdecvalue[valAt] * (int)Math.Pow(16, i);
        //    }
        //    return result;
        //}
        //static void Main()
        //{
        //    string hex = Console.ReadLine().Trim();

        //    //string hex = 29A;
        //    Console.WriteLine("Hex : {0} is dec : {1}", hex, HexToDec(hex));


        //Other 
        //Console.Write("Enter you hexadecimal value: ");
        //string hexa = Console.ReadLine();

        //long dec = long.Parse(hexa, NumberStyles.HexNumber);

        //Console.WriteLine(dec);
    }
}