using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01MaxSequenceOfEqualElement
{
    class MaxSequenceOfEqualElement
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();

            int counter = 1;
            int bestNumbers = 1;
            int bestLen = 0;

            //ZADACHATA RABOTI ? KATO SE PRISVOQVA NA PROMENLIVA CHISLOTO KOETO SE POVTARQ A NE DA OTPECHATVA OT LISTA
            //DADENITE ELEMENTI OT DADENA POZICIQ DO DADENA KRAINA POZICIQ !!!!!!!!!!!!!!!!!1

            for (int i = 0; i < input.Count - 1; i++)
            {
                if (input[i] == input[i + 1])
                {
                    counter++;

                    if (counter > bestLen)
                    {
                        bestLen = counter;
                        bestNumbers = input[i];
                    }
                }

                if (input[i] != input[i + 1])
                {
                    counter = 1;
                }

                if (bestLen == 1)
                {
                    bestNumbers = input[0];
                }
            }

            for (int i = 0; i < bestLen; i++)
            {
                Console.Write(bestNumbers + " ");
            }
            //Console.WriteLine(string.Join(" ", input[bestLen]));
        }
    }
}
