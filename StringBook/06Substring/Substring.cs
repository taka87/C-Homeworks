using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06Substring
{
    class Substring
    {
        static void Main(string[] args)
        {
            string location = "C:\\Pics\\Rila2010.jpg";

            string isInclude = location.Substring(9, 7);  //(start index, lenght)

            Console.WriteLine(isInclude);
        }
    }
}
