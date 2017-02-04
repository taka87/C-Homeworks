using System;
using System.Collections.Generic;
using System.Linq;

namespace _12Linq
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = new List<int>() { 1, 2, 3, 4, 5, 6, 6, 7, 8, 9, 9 };

            Console.WriteLine(string.Join(", ", numbers.OrderBy(x => x = -x).ThenBy(x => x)));

            Dictionary<string, int> dic = new Dictionary<string, int>();
            dic.Add("pesho", 5);
            dic.Add("fsv", 15);
            dic.Add("vdfvo", 225);
            dic.Add("vdfv", 35);
            dic.Add("vd", 45);
            dic.Add("vssd", 45);
            dic.Add("vdddfv", 25);
            dic.Add("sdc", 15);
            dic.Add("psdcsdco", 5);

            foreach (var i in dic)
            {
                Console.WriteLine("{0} - > {1}", i.Key, i.Value);
            }

            Console.WriteLine(string.Join(", ", dic.Where(word => word.Value < 5)));
        }
    }
}
