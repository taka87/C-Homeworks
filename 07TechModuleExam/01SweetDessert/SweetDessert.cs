using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01SweetDessert
{
    class SweetDessert
    {
        static void Main(string[] args)
        {
            double money = double.Parse(Console.ReadLine());
            int guests = int.Parse(Console.ReadLine());
            double priceBanans = double.Parse(Console.ReadLine());
            double priceEggs = double.Parse(Console.ReadLine());
            double priceBerryes = double.Parse(Console.ReadLine());
            int porcions = 0;
            double neededAmmount = 0;

            if (guests % 6 == 1 || guests % 6 == 2 || guests % 6 == 3 || guests % 6 == 4 || guests % 6 == 5)
            {
                porcions = guests / 6;
                porcions += 1;
            }
            else
            {
                porcions = guests / 6;
            }
            //Console.WriteLine(porcions);

            neededAmmount = (porcions * 2) * priceBanans + (porcions * 4) * priceEggs + (porcions * 0.2) * priceBerryes;

            if (neededAmmount <= money)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:f2}lv.", neededAmmount);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:f2}lv more.", neededAmmount - money);
            }
        }
    }
}
