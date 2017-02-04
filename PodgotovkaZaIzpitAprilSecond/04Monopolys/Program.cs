using System;
using System.Collections.Generic;
using System.Linq;

class Program
{
    static void Main()
    {
        int money = 50;
        int numberOfHotels = 0;
        int numberOfTurns = 0;
        int[] dimentions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int rows = dimentions[0];
        int cols = dimentions[1];
        List<List<char>> matrix = new List<List<char>>();
        for (int row = 0; row < rows; row++)
        {
            matrix.Add(Console.ReadLine().ToCharArray().ToList());
        }

        for (int row = 0; row < rows; row++)
        {
            if (row % 2 == 0)
            {
                for (int col = 0; col < cols; col++)
                {
                    char currentCharater = matrix[row][col];
                    switch (currentCharater)
                    {
                        case 'J':
                            Console.WriteLine("Gone to jail at turn {0}.", numberOfTurns);
                            numberOfTurns += 2;
                            money += 2 * (numberOfHotels * 10);
                            break;
                        case 'S':
                            int product = (row + 1) * (col + 1);
                            if (product > money)
                            {
                                Console.WriteLine("Spent {0} money at the shop.", money);
                                money = 0;
                            }
                            else
                            {
                                Console.WriteLine("Spent {0} money at the shop.", product);
                                money -= product;
                            }
                            break;
                        case 'H':
                            numberOfHotels++;
                            Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, numberOfHotels);
                            money = 0;
                            break;
                    }

                    money += numberOfHotels * 10;
                    numberOfTurns++;
                }
            }
            else
            {
                for (int col = cols - 1; col >= 0; col--)
                {
                    char currentCharater = matrix[row][col];
                    switch (currentCharater)
                    {
                        case 'J':
                            Console.WriteLine("Gone to jail at turn {0}.", numberOfTurns);
                            numberOfTurns += 2;
                            money += 2 * (numberOfHotels * 10);
                            break;
                        case 'S':
                            int product = (row + 1) * (col + 1);
                            if (product > money)
                            {
                                Console.WriteLine("Spent {0} money at the shop.", money);
                                money = 0;
                            }
                            else
                            {
                                Console.WriteLine("Spent {0} money at the shop.", product);
                                money -= product;
                            }
                            break;
                        case 'H':
                            numberOfHotels++;
                            Console.WriteLine("Bought a hotel for {0}. Total hotels: {1}.", money, numberOfHotels);
                            money = 0;
                            break;
                    }

                    money += numberOfHotels * 10;
                    numberOfTurns++;
                }
            }
        }
        Console.WriteLine("Turns {0}", numberOfTurns);
        Console.WriteLine("Money {0}", money);
    }
}
