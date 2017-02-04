using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08EmplyeeDetails
{
    class EmplyeeDetails
    {
        static void Main(string[] args)
        {

            //            Amanda
            //            Jonson
            //27
            //f
            //8306112507
            //27563571    First name: Amanda
            //Last name: Jonson
            //Age: 27
            //Gender: f
            //Personal ID: 8306112507
            //Unique Employee number: 27563571

            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());
            long personalID = long.Parse(Console.ReadLine());
            int num = int.Parse(Console.ReadLine());

            Console.WriteLine("First name: {0}", firstName);
            Console.WriteLine("Last name: {0}", lastName);
            Console.WriteLine("Age: {0}", age);
            Console.WriteLine("Gender: {0}", gender);
            Console.WriteLine("Personal ID: {0}", personalID);
            Console.WriteLine("Unique Employee number: {0}", num);
        }
    }
}
