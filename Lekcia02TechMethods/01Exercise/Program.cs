using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            byte century = 0;

            for (int i = 0; i < 300; i++)
            {
                checked // dava greshka za da ne prehvurlq
                {
                    century++;
                    Console.WriteLine(century);
                }
            }
        }
    }
}
