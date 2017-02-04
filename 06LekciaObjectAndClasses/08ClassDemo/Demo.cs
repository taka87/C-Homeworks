using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08ClassDemo
{
    class Demo
    {
        static void Main(string[] args)
        {

            string[] firstPoint = Console.ReadLine().Split();
            string[] secondPoint = Console.ReadLine().Split();

            int firstPointX = int.Parse(firstPoint[0]);
            int firstPointY = int.Parse(firstPoint[1]);
            int secondPointX = int.Parse(secondPoint[0]);
            int secondPointY = int.Parse(secondPoint[1]);

            //Point firstPoint = new Point() { X = firstPointX, Y = firstPointY };
            //Point secondPoint = new Point() { X = secondPointX, Y = secondPointY };


            //Console.WriteLine(firstPoint.CalcPoint(secondPoint));
        }
        //Point pointA = new Point() { x = 5; y = 5; }

        // Point.X = 5;

        public double CalcPoint(Point firstPoint, Point secondPoint)
        {
            double firstDiff = (firstPoint.X - secondPoint.X) * (firstPoint.X - secondPoint.X);
            double secondDiff = (firstPoint.Y - secondPoint.Y) * (firstPoint.Y - secondPoint.Y);

            double sqrd = Math.Sqrt(firstDiff + secondDiff);

            return sqrd;
        }
        // Vlojen klas v "CLASS DEMO"
        public class Point
        {
            // get read only   // set da zadava stoinosti
            // public int X{get;}
            public int X { get; set; }
            public int Y { get; set; }
        }
    }

    //public class Point
    //{
    //    // get read only   // set da zadava stoinosti
    //    // public int X{get;}
    //    public int X { get; set; }
    //    public int Y { get; set; }
    //}
}

