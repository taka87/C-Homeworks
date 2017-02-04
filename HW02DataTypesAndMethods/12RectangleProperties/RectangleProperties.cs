using System;
using System.Globalization;

namespace _12RectangleProperties
{
    class RectangleProperties
    {
        static void Main(string[] args)
        {
            //Console.Write("Add Rectangle's width: ");
            double width = double.Parse(Console.ReadLine());
           //Console.Write("Add Rectangle's height: ");
            double height = double.Parse(Console.ReadLine());
            double pOfRectangle = 2 * (width + height);
            double aOfRectangle = width * height;
            double diagonal = Math.Sqrt((width*width) +(height*height));

            Console.WriteLine(pOfRectangle);
            Console.WriteLine(aOfRectangle);
            Console.WriteLine(diagonal);
        }
    }
}
