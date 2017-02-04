using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02StaticClasses
{
    public class Sequanse
    {
        private static int currentValue = 0;

        private Sequanse()
        {

        }
        public static int NextValue()
        {
            currentValue++;
            return currentValue;

        }
    }
    class StaticClasses
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sequence [1..3] {0} {1} {2}", Sequanse.NextValue(),Sequanse.NextValue(),Sequanse.NextValue());
        }
    }
}
