using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07matrixGenerator
{
    class MaxSeuenceCOPY
    {
        static void Main(string[] args)
        {
            List<int> ListEnter = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
            int[] matrix = new int[ListEnter.Max() + 1];
            List<int> result = new List<int>();
            List<int> resultMax = new List<int>();
            int[,] matrix1 = new int[ListEnter.Max() + 1, ListEnter.Max() + 1];


            //  int i = 1;
            int countermax = 0;
            int chislo = 0;
            int counter = 0;

            for (int i = 0; i < ListEnter.Count; i++)
            {
                for (int k = i; k < ListEnter.Count; k++)
                {
                    if (ListEnter[i] == ListEnter[k])
                    {
                        counter++;
                    }
                }
                if (counter > countermax)
                {
                    countermax = counter;
                    chislo = ListEnter[i];
                }
                counter = 0;
            }


            for (int i = 0; i < countermax; i++)
            {
                Console.Write("{0} ", chislo);
            }
            Console.WriteLine();
        }
    }
}
