using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05OverlappingScope
{
    public class Program
    {
        int myValue = 3;

        void PrintMyValue()
        {
            Console.WriteLine("My value is : {0}", myValue);
        }
        static void Main(string[] args)
        {
            Program instance = new Program();
            instance.PrintMyValue();
        }

        int NewValue(int newValue)
        {
            int res = myValue + newValue;
            return res;
        }

        void PrintMyValue()
        {
            int myValue = 5;
            Console.WriteLine("My value is : {0}" + this.myValue);
        }
    }
}
