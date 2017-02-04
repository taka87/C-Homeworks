using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04RandomNumbers
{
    class RandomNumbers
    {
        static void Main(string[] args)
        {

            //overload na metoda ni kazva kak moje da se izpolzva metoda rnd.Next ima 2 overload samo kraina granica 
            //     -> ili nachalna i kraina granica iska tova sa dva overload

            Random rnd = new Random();

            Console.WriteLine(rnd.Next(1,100));

            //Thread.Sleep(3000);  zabavq izpalnenieto na programata ni s 3 sekundi primerno

        }
    }
}
