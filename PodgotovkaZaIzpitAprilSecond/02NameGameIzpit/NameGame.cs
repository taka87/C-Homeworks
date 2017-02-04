using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace NameGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            int score = Int32.MinValue;
            string winner = "";
            for (int i = 0; i < num; i++)
            {
                string name = Console.ReadLine();
                int initialScore = int.Parse(Console.ReadLine());
                for (int j = 0; j < name.Length; j++)
                {
                    if (name[j] % 2 == 0)
                    {
                        initialScore += name[j];
                    }
                    else
                    {
                        initialScore -= name[j];
                    }
                }
                if (initialScore >= score)
                {
                    score = initialScore;
                    winner = name;
                }
            }
            Console.WriteLine("The winner is {0} - {1} points", winner, score);
        }
    }
}
