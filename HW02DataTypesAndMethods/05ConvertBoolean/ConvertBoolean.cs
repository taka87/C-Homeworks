using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05ConvertBoolean
{
    class ConvertBoolean
    {
        static void Main(string[] args)
        {
            string boolean = Console.ReadLine();

            bool isBoolean = Convert.ToBoolean(boolean);

            if (isBoolean)
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}