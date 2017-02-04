using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11StringConcatenation
{
    class Program
    {
        static void Main(string[] args)
        {
            //otnema okolo 2 sekundi 
            Console.WriteLine(DateTime.Now);

            string colector = "Numberas";

            for (int i = 0; i <= 20000; i++)
            {
                colector += i;
            }

            //Console.WriteLine(colector.Substring(0,1024));
            Console.WriteLine(colector);

            Console.WriteLine(DateTime.Now);
        }
    }
}
