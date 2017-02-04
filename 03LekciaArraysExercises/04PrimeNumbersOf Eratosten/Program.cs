using System;
using System.Collections.Generic;

namespace _04PrimeNumbersOf_Eratosten
{
    class Program
    {
        static void Main(string[] args)
        {
            long input = int.Parse(Console.ReadLine());

            long prime1 = 2;
            long prime2 = 3;
            long prime3 = 5;
            long prime4 = 7;

            for (int i = 2; i <= input; i++)
            {
                    switch (i)
                    {
                        case 2:
                            Console.Write("2 ");
                            break;
                        case 3:
                            Console.Write("3 ");
                            break;
                        case 5:
                            Console.Write("5 ");
                            break;
                        case 7:
                            Console.Write("7 ");
                            break;
                        default:
                            break;
                    }                
            }

            List<long> result = new List<long>();

            if (input >= 10)
            {
                for (long i = 10; i <= input + 1; i++)
                {
                    if (i % prime1 != 0 && i % prime2 != 0 && i % prime3 != 0 && i % prime4 != 0)
                    {
                        result.Add(i);
                        //Console.Write(i+ " ");
                    }
                }
            }

            Console.Write(string.Join(" ", result));
        }
    }
}
