using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07PrintMyName
{
    class Program
    {
        static void Main(string[] args)
        {
            int age = 22;
            string goshko = "Toshko";

            Console.WriteLine($"My name is {goshko} and my age is {age}");
            Console.WriteLine($"My name is {0} and my age is {1}", goshko, age);
            Console.WriteLine("My name is {0} and my age is {1}", goshko, age);
            Console.WriteLine("My name is " + goshko + " and my age is " + age);
        }
    }
}
