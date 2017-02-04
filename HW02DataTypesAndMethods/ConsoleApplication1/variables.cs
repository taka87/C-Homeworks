using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class variables
    {
        static void Main(string[] args)
        {
            sbyte smallNum = sbyte.Parse(Console.ReadLine());
            byte secondNum = byte.Parse(Console.ReadLine());
            short thirNum = short.Parse(Console.ReadLine());
            ushort fouthNum = ushort.Parse(Console.ReadLine());
            uint fifthNum = uint.Parse(Console.ReadLine());
            long sixthNum = long.Parse(Console.ReadLine());
            decimal seventNum = decimal.Parse(Console.ReadLine());

            Console.WriteLine(smallNum);
            Console.WriteLine(secondNum);
            Console.WriteLine(thirNum);
            Console.WriteLine(fouthNum);
            Console.WriteLine(fifthNum);
            Console.WriteLine(sixthNum);
            Console.WriteLine(seventNum);
        }
    }
}
