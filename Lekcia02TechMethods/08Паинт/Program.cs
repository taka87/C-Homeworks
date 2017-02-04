using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Паинт
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            draw(num);
            for (int i = 0; i < num - 2; i++)
            {
                DrawMiddle(num);
            }
            draw(num);
        }

        static void draw(int size)
        {
            //Console.WriteLine(new string(size*2));
            for (int i = 0; i < size - 2; i++)
            {
                Console.Write("-");
            }

        }

        static void DrawMiddle(int size)
        {
            Console.Write('-');
            for (int i = 0; i < size - 1; i++)
            {
                if (i % 2 == 0)
                {
                    Console.Write("\\/");
                }
            }
            Console.WriteLine('-');
        }
    }
}
