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
            decimal ammount = decimal.Parse(Console.ReadLine());
            int numOfGuests = int.Parse(Console.ReadLine());
            double bananas = double.Parse(Console.ReadLine());
            double eggs = double.Parse(Console.ReadLine());
            double berries = double.Parse(Console.ReadLine());

            int razlika = numOfGuests % 6;
            int porcions = 0;
            int porcii = 0;

            if (razlika == 5)
            {
                porcions += 1;
            }
            else if (razlika == 4)
            {
                porcions += 2;
            }
            else if (razlika == 3)
            {
                porcions += 3;
            }
            else if (razlika == 2)
            {
                porcions += 4;
            }
            else if (razlika == 1)
            {
                porcions += 5;
            }

            porcii = ((numOfGuests + porcions) / 6);
            //Console.WriteLine(porcii);

            double neededAmmount = (porcii * (2 * bananas)) + (porcii * (4 * eggs)) + (porcii * (0.2 * berries));

            //Console.WriteLine(porcii);
            if (ammount >= (decimal)neededAmmount)
            {
                Console.WriteLine("Ivancho has enough money - it would cost {0:0.00}lv.", neededAmmount);
            }
            else
            {
                Console.WriteLine("Ivancho will have to withdraw money - he will need {0:0.00}lv more.", (decimal)neededAmmount - ammount);
            }
        }
    }
}
