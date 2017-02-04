using System;
using System.Linq;
using System.Collections.Generic;

class DreamItem
{
    static void Main()
    {
        string inputData = Console.ReadLine();
        string[] data = new string[] { };
        List<string> newList = new List<string> { };
        List<decimal> doubleList = new List<decimal> { };

        char[] delimiterChars = { '\\' };
        string[] words = inputData.Split(delimiterChars);
        decimal sum = 0;
        decimal sum1 = 0;

        for (int i = 0; i < words.Length; i++)
        {
            newList.Add(words[i]);
        }
        decimal temp;
        doubleList = newList.Select(x => decimal.TryParse(x, out temp) ? temp : 0).ToList<decimal>(); ;
        //doubleList = newList.Select(x => decimal.TryParse(x, out temp) ? temp : 0).ToList();

        if (newList[0] == "Jan")
        {
            sum = 21 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "Feb")
        {
            sum = 18 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
            }
        }
        else if (newList[0] == "Mar")
        {
            sum = 21 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "Apr")
        {
            sum = 20 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "May")
        {
            sum = 21 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "June")
        {
            sum = 20 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "July")
        {
            sum = 21 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "Aug")
        {
            sum = 21 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "Sept")
        {
            sum = 20 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "Oct")
        {
            sum = 21 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "Nov")
        {
            sum = 20 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
        else if (newList[0] == "Dec")
        {
            sum = 21 * doubleList[1] * doubleList[2];
            if (sum > 700)
            {
                sum1 = sum + sum * 0.1m;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
            else
            {
                sum1 = sum;
                if (sum1 > doubleList[3])
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));
                }
                else if (sum1 < doubleList[3])
                {
                    Console.WriteLine("Not enough money. {0:F2} leva needed.", (doubleList[3] - sum1));
                }
                else
                {
                    Console.WriteLine("Money left = {0:F2} leva.", (sum1 - doubleList[3]));

                }
            }
        }
    }
}
