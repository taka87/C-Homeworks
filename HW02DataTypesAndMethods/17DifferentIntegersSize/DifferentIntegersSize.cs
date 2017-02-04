using System;
using System.Numerics;

namespace _17DifferentIntegersSize
{
    class DifferentIntegersSize
    {
        static void Main(string[] args)
        {
            //sbyte < byte < short < ushort < int < uint < long

            //sbyte  -128 .. 127
            //byte  0.. 255            
            //short   -32,768 .. 32,767
            //ushort   0 .. 65,535
            //int   	-2,147,483,648.. 2,147,483,647
            //uint      0 .. 4,294,967,295
            //long   -9,223,372,036,854,775,808 .. 9,223,372,036,854,775,807

            BigInteger n = BigInteger.Parse(Console.ReadLine());

            if (n <= long.MaxValue && n >= long.MinValue)
            {
                Console.WriteLine($"{n} can fit in:");
                sbyte sbyteMax = sbyte.MaxValue;
                sbyte sbyteMin = sbyte.MinValue;

                byte byteMax = byte.MaxValue;

                short shortMax = short.MaxValue;
                short shortMin = short.MinValue;

                ushort ushortMax = ushort.MaxValue;

                int intMax = int.MaxValue;
                int intMin = int.MinValue;

                uint uintMax = uint.MaxValue;

                long longMax = long.MaxValue;
                long longMin = long.MinValue;

                if (n <= sbyteMax && n >= sbyteMin || n == 0)
                {
                    Console.WriteLine("* sbyte");
                }

                if (n <= byteMax && n >= 0)
                {
                    Console.WriteLine("* byte");
                }
                if (n <= shortMax && n >= shortMin || n == 0)
                {
                    Console.WriteLine("* short");
                }
                if (n <= ushortMax && n >= 0)
                {
                    Console.WriteLine("* ushort");
                }
                if (n <= intMax && n >= intMin || n == 0)
                {
                    Console.WriteLine("* int");
                }
                if (n <= uintMax && n >= 0)
                {
                    Console.WriteLine("* uint");
                }
                if (n <= longMax && n >= longMin || n == 0)
                {
                    Console.WriteLine("* long");
                }
            }
            else
            {
                Console.WriteLine($"{n} can't fit in any type");
            }
        }
    }
}