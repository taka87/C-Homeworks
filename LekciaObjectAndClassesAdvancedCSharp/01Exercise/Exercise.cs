using System;

namespace Date
{
    class Exercise
    {
        static void Main()
        {
            DateTime birthday = DateTime.Now;
            //DateTime newDate = new DateTime();

            Console.WriteLine(birthday.Day + 1);
            Console.WriteLine(birthday);

            Random newRandom = new Random();

            int randomNum = newRandom.Next(0, 11);
            Console.WriteLine(randomNum);

            if (randomNum<=5)
            {
                Console.WriteLine("The number is smaller than : 5");
            }
            else
            {
                Console.WriteLine("it is not cool");
            }
        }
        public static void PrintNums()
        {
            //var birth = new System.DateTime();

        }
    }
}