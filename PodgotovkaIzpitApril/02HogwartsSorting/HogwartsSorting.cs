using System;
using System.Linq;

class HogwartsSorting
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] result = new int[n];

        int gryffindor = 0;
        int slytherin = 0;
        int ravenclaw = 0;
        int hufflepuff = 0;

        for (int i = 0; i < n; i++)
        {
            //Gryffindor (if reminder = 0), Slytherin (if 1), Ravenclaw (if 2) and Hufflepuff (if 3)
            char[] input = Console.ReadLine().ToCharArray();
            string letter = string.Empty;

            for (int j = 0; j < input.Length; j++)
            {
                if (j == 0)
                {

                    letter += input[j];
                }
                else if (input[j]==' ')
                {
                    letter += input[j + 1];
                } 
                if (input[j] != ' ' && input[j] != 32)
                {
                    result[i] += input[j];

                }
            }
            if (result[i] % 4 == 0)
            {
                Console.WriteLine("Gryffindor {0}{1}", result[i], letter);
                gryffindor++;
            }
            else if (result[i] % 4 == 1)
            {
                Console.WriteLine("Slytherin {0}{1}", result[i], letter);
                slytherin++;
            }
            else if (result[i] % 4 == 2)
            {
                Console.WriteLine("Ravenclaw {0}{1}", result[i], letter);
                ravenclaw++;
            }
            else if (result[i] % 4 == 3)
            {
                Console.WriteLine("Hufflepuff {0}{1}", result[i], letter);
                hufflepuff++;
            }
            else
            {
                Console.WriteLine("incorrect");
            }

        }

        Console.WriteLine();
        Console.WriteLine("Gryffindor: {0}", gryffindor);
        Console.WriteLine("Slytherin: {0}", slytherin);
        Console.WriteLine("Ravenclaw: {0}", ravenclaw);
        Console.WriteLine("Hufflepuff: {0}", hufflepuff);
    }
}