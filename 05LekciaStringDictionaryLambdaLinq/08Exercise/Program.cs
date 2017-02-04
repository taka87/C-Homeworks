using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            string myStr = "Hello C#";

            string edit = myStr.Replace('#', 'S');

            Console.WriteLine(edit);

            string substring = edit.Substring(2, edit.Length - 4);

            Console.WriteLine(substring); // substring zapazva noviq red remove gi maha 
            //substring - > besho e gotin  ->  "ho e g"
            //replace - > pesho e gotin "pe otin"
        }
    }
}
