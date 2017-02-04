using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13ClosestTwoPoints
{
    class ClosestTwoPoints
    {
        static void Main(string[] args)
        {
            Point[] points = ReadPoints();

            var closesPoints = FindClosestTwoPoints(points);

            Console.WriteLine("{0:f3}", CalcDistance(closesPoints[0], closesPoints[1]));

            PrintPoints(closesPoints[0]);
            PrintPoints(closesPoints[1]);

        }

        private static Point[] ReadPoints()
        {
            int n = int.Parse(Console.ReadLine());
            Point points = new Point[n];

            for (int i = 0; i < n; i++)
            {
                points[i] = ReadPoint();
            }

            return points;
        }

        private static Point ReadPoint()
        {
            int n = int.Parse(Console.ReadLine()); 

            Point firstPoint = new Point();// { X = firstPointX, Y = firstPointY };
            Point secondPoint = new Point();// { X = secondPointX, Y = secondPointY };

            
        }

        static void PrintPoints(Point point)
        {
            Console.WriteLine("({0}, {1})", point.X, point.Y);
        }

        static Point[] FindClosestTwoPoints(Point[] points)
        {
            var minDistance = double.MaxValue;
            Point[] closestTwoPoints = null;

            for (int i = 0; i < points.Length; i++)
            {
                for (int j = i + 1; j < points.Length; j++)
                {
                    var distance = CalcDistance(points[i], points[j]);

                    if (distance < minDistance)
                    {
                        minDistance = distance;
                        closestTwoPoints = new Point[] { Point[i], Point[j] };
                    }
                }
            }
            return closestTwoPoints;
        }

        static double CalcDistance(Point p1, Point p2)
        {
            var deltaX = p2.X - p1.X;
            var deltaY = p2.Y - p1.Y;

            return Math.Sqrt(deltaX * deltaX + deltaY * deltaY);
        }

        class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
        }
    }
}
