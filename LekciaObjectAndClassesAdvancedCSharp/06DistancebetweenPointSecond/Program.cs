using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06DistancebetweenPointSecond
{
    //class Point
    //{
    //    public int ReadPoint { get; set; }
    //    public int p2 { get; set; }

    //    //private static int ReadPoint()
    //    //{
    //    //    int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //    //    int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
    //    //}
    //}
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = ReadPoint();
            Point p2 = ReadPoint();

        }
        private static int ReadPoint()
        {
            int[] input = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
            int[] input1 = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        }
    }
}
