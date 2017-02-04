using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12BombNumberCopyTOD
{
    class BombNumberCopyTOD
    {
        static void Main(string[] args)
        {
            //zadavat se dva masiva s chisla kato parviq index na vtoriq e namereneoto chislo ot parviq masiv da se 
            //premahnat okolo nego vklyuchitelno i to vsichki elementi s pozicii ot vtoriq indeks ot vtoriq masiv !
            int[] InputNumbers = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] numberwithPower = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int number = numberwithPower[0];
            int power = numberwithPower[1];
            int sum = 0;

            for (int i = 0; i < InputNumbers.Length; i++)
            {
                if (InputNumbers[i] == number)
                {
                    for (int j = i - power; j <= i + power; j++)
                    {
                        try
                        {
                            InputNumbers[j] = 0;
                        }
                        catch
                        {

                        }
                    }
                }
            }

            for (int i = 0; i < InputNumbers.Length; i++)
            {
                sum = sum + InputNumbers[i];
            }
            Console.WriteLine(sum);
        }
    }
}
