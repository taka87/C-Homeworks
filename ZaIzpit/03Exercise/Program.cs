using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace _03.DrawStraw
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int numOfdashesmid = n;
            int numOfdashesSide = 0;
            int numOfdashesOnSide = n + 2;
            int dots = -3;
            int dotsmid = (n * 2) - 1 + 2;
            int secondsidedashes = 0;
            Console.WriteLine("\\{0}|{0}/", new string('-', n));
            for (int i = 0; i < Math.Floor((double)(n / 2) - 1); i++)
            {
                numOfdashesSide += 2;
                numOfdashesmid -= 2;
                Console.WriteLine("{0}\\{1}|{1}/{0}", new string('-', numOfdashesSide), new string('-', numOfdashesmid));
            }
            for (int j = 0; j < Math.Ceiling((double)(n / 2) + 1); j++)
            {
                dots += 4;
                numOfdashesOnSide -= 2;
                Console.WriteLine("{0}#{1}#{0}", new string('-', numOfdashesOnSide), new string('.', dots));

            }
            Console.WriteLine("#{0}#", new string('.', (n * 2) + 1));
            for (int i = 0; i < n; i++)
            {
                dotsmid -= 2;
                secondsidedashes += 1;
                Console.WriteLine("{0}#{1}#{0}", new string('-', secondsidedashes), new string('.', dotsmid));
            }
        }
    }
}