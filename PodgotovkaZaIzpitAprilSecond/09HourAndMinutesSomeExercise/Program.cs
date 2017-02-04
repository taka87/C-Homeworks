using System;

namespace _15
{
    class Program
    {
        static void Main()
        {
            int hour = int.Parse(Console.ReadLine());
            int min = int.Parse(Console.ReadLine());

            string hours = hour + ":" + (min + 15);

            DateTime alarm = new DateTime();
            alarm = DateTime.ParseExact(hours, "H:m", null);

            Console.Write(alarm.Hour + ":");
            Console.Write(alarm.Minute);

            //    var hour = int.Parse(Console.ReadLine());
            //    var mins = int.Parse(Console.ReadLine());
            //    var min15 = (mins + 15);
            //    if (hour == 23)
            //    {
            //        if (min15 > 60)
            //        {
            //            if ((min15 - 60) < 10) { Console.WriteLine("0:0" + (min15 - 60)); }
            //            if ((min15 - 60) >= 10) { Console.WriteLine("0:" + (min15 - 60)); }
            //        }
            //        if (min15 == 60) { Console.WriteLine("0:00"); }
            //        if (min15 < 60) { Console.WriteLine("23:" + min15); }
            //    }
            //    else
            //    {
            //        if (min15 > 60)
            //        {
            //            if ((min15 - 60) < 10) { Console.WriteLine((hour + 1) + ":0" + (min15 - 60)); }
            //            if ((min15 - 60) >= 10) { Console.WriteLine((hour + 1) + ":" + (min15 - 60)); }
            //        }
            //        if (min15 == 60) { Console.WriteLine((hour + 1) + ":00"); }
            //        if (min15 < 60) { Console.WriteLine(hour + ":" + min15); }
            //    }
        }
    }
}