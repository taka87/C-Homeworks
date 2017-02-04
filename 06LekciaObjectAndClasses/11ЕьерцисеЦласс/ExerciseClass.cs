using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11ЕьерцисеЦласс
{
    class ExerciseClass
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.Width = int.Parse(Console.ReadLine());
            rectangle.Height = int.Parse(Console.ReadLine());
            rectangle.Top = int.Parse(Console.ReadLine());
            rectangle.Left = int.Parse(Console.ReadLine());

            Rectangle secondRectangle = new Rectangle();
            rectangle.Width = int.Parse(Console.ReadLine());
            rectangle.Height = int.Parse(Console.ReadLine());
            rectangle.Top = int.Parse(Console.ReadLine());
            rectangle.Left = int.Parse(Console.ReadLine());

            Console.WriteLine(rectangle.CalcArea());
            Console.WriteLine(secondRectangle.CalcArea());
        }

        public class Rectangle
        {
            public int Top { get; set; }
            public int Left { get; set; }

            public int Width
            {
                get
                {
                    return this.Width;
                }
                set
                {
                    if (value >= 0)
                    {
                        this.Width = value;
                    }
                }
            }


            public int Height { get; set; }
            //prop tab tab

            public int asdfsas { get; set; }

            public int CalcArea()
            {
                return this.Width * this.Height;
            }
        }
    }
}
