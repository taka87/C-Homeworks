using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Elevator
{
    class Program
    {
        static void Main(string[] args)
        {
            int numPeople = int.Parse(Console.ReadLine());
            int capacity = int.Parse(Console.ReadLine());

            int people = numPeople / capacity;

            if (numPeople % capacity != 0)
            {
                people++;
                
            }
            Console.WriteLine(people);
        }
    }
}
