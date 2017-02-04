using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

class MonopolyGame
{
    static void Main()
    {
        int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        int n = input[0];
        int m = input[1];

        //List<char[]> monopoly = new List<char[]>();
        char[,] monopoly = new char[n, m];

        int money = 50;
        int hotels = 0;
        int turns = 0;

        for (int i = 0; i < n; i++)
        {
            char[] inputa = Console.ReadLine().ToCharArray();
            for (int j = 0; j < m; j++)
            {
                monopoly[i, j] = inputa[j];
            }
        }

        for (int i = 0; i < n; i++)
        {
            if (i % 2 == 0)
            {
                // char currentCharater = matrix[row][col];
                for (int j = 0; j < m; j++)
                {
                    if (monopoly[i, j] == 'H')
                    {
                        hotels++;
                        Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, hotels);
                        money = 0;
                    }
                    else if (monopoly[i, j] == 'J')
                    {
                        Console.WriteLine("Gone to jail at turn {0}.", turns);
                        money += (10 * hotels) * 2;
                        turns += 2;
                    }
                    else if (monopoly[i, j] == 'S')
                    {
                        if (money < (i + 1) * (j + 1))
                        {
                            Console.WriteLine("Spent {0} money at the shop.", money);
                            money = 0;
                        }
                        else
                        {
                            Console.WriteLine("Spent {0} money at the shop.", (i + 1) * (j + 1));
                            money -= ((i + 1) * (j + 1));
                        }
                    }
                    turns++;
                    money += hotels * 10;
                }
            }
            else
            {
                for (int l = m-1; l >= 0; l++)
                {
                    if (monopoly[i, l] == 'H')
                    {
                        hotels++;
                        Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, hotels);
                        money = 0;
                    }
                    else if (monopoly[i,l] == 'J')
                    {
                        Console.WriteLine("Gone to jail at turn {0}.", turns);
                        money += (10 * hotels) * 2;
                        turns += 2;
                    }
                    else if (monopoly[i, l] == 'S')
                    {
                        if (money < (i + 1) * (l + 1))
                        {
                            Console.WriteLine("Spent {0} money at the shop.", money);
                            money = 0;
                        }
                        else
                        {
                            Console.WriteLine("Spent {0} money at the shop.", (i + 1) * (l + 1));
                            money -= ((i + 1) * (l + 1));
                        }
                    }
                    turns++;
                    money += hotels * 10;
                }
            }
        }
        Console.WriteLine("Turns {0}", turns);
        Console.WriteLine("Money {0}", money);
    }
}