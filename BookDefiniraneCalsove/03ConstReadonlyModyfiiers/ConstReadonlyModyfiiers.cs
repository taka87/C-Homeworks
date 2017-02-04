using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03ConstReadonlyModyfiiers
{
    public class ConstReadonlyModyfiiers
    {
        public const double PI = 3.1415926;
        public readonly double size;

        public ConstReadonlyModyfiiers(int size)
        {
            this.size = size; // cannot be future modyfied
        }
        static void Main(string[] args)
        {
            Console.WriteLine(PI);
            Console.WriteLine(ConstReadonlyModyfiiers.PI);
            ConstReadonlyModyfiiers t = new ConstReadonlyModyfiiers(5);
            Console.WriteLine(t.size);

            //this will cause compule time error
            //Console.WriteLine(ConstReadonlyModyfiiers.size);  //?? kakvo se sluchva tuk zashto ne raboti
        }
    }
}
