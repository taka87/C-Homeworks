using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08StringReplace
{
    class StringReplace
    {
        static void Main(string[] args)
        {
            string someMail = "Hello, some@gmail.com, " +"you have been using some@gmail.com in your registration.";

            string fixedDoc = someMail.Replace("some@gmail.com", "nqkakuv@si-meil.bg");

            Console.WriteLine(fixedDoc);
        }
    }
}
