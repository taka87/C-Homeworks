using System;
using System.Globalization;

namespace _02DayOfWeek
{
    class DayOfWeek
    {
        static void Main(string[] args)
        {
            // bool date = tryparse exact iska da si raboti s bool i vrashta stoinost s out grade
            // DateTime grade = new DateTime();
            // bool times = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy");   // tova ne raboti no neshto podobno beshe
            //tuk prosto ne garmi s exception


            //parse gurmi
            //parseExact vavejdame nachina po koito iskame da vkarame
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "d-M-yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(date.DayOfWeek);
            Console.WriteLine("{0:d.M.yyyy}", date);   // po tozi nachin se mahat minuti sekundi chasovete koito po default dava
        }
    }
}
