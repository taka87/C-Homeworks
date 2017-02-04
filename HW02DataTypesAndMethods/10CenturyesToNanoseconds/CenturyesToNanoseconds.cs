using System;

namespace _10CenturyesToNanoseconds
{
    class CenturyesToNanoseconds
    {
        static void Main(string[] args)
        {
            //years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds.

            byte a = byte.Parse(Console.ReadLine());
            ushort years = (ushort)(a * 100);
            int days = (int)(years * 365.2422);
            int hours = days * 24;
            decimal minutes = hours * 60m;
            decimal seconds = minutes * 60m;
            decimal milisec = seconds * 1000;
            decimal microsec = milisec * 1000;
            decimal nanosec = microsec * 1000;

            Console.Write($"{a} centuries = {years} years = {days} days = {hours} hours = {minutes}");
            Console.Write($" minutes = {seconds} seconds = {milisec} milliseconds = {microsec}");
            Console.Write($" microseconds = {nanosec} nanoseconds");
            //Console.WriteLine(a);
            //Console.WriteLine(years);
            //Console.WriteLine(days);
            //Console.WriteLine(hours);
            //Console.WriteLine(minutes);
            //Console.WriteLine(seconds);
            //Console.WriteLine(milisec);
            //Console.WriteLine(microsec);
            //Console.WriteLine(nanosec);


            //Write program to enter an integer number of centuries and convert it to years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds

            //  int centuries = int.Parse(Console.ReadLine());
            //  int years = centuries * 100;
            //  int days = (int)(years * 365.2422);
            //  int hours = days * 24;
            //  decimal minutes = hours * 60M;
            //  decimal seconds = minutes * 60M;
            //  decimal milliseconds = seconds * 1000M;
            //  decimal microseconds = milliseconds * 1000;
            //  decimal nanoseconds = microseconds * 1000;
            //  Console.WriteLine("{0} centuries = {1} years = {2} days = {3} hours = {4} minutes = {5} seconds = {6} milliseconds = {7} microseconds = {8} nanoseconds", centuries, years, days, hours, minutes, seconds, milliseconds, microseconds, nanoseconds);
        }
    }
}
