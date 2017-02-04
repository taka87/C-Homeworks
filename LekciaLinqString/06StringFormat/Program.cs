using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06StringFormat
{
    class Program
    {
        static void Main(string[] args)
        {

            double d = 37.056;

            string s = string.Format("0,10:F5", d);


            int num = 42;
            Console.WriteLine("Dec {0:D} = Hex {1:X}", num, num);
        }
    }
}
