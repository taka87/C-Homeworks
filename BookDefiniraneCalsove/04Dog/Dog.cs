using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04Dog
{
    class Dog
    {
        //RAZGLEDAI GI S F11 KAK RABOTI !!!


        int age = 2;

        static void Main(string[] args)
        {
            Dog dog = new Dog();

            Console.WriteLine("Dog's age is : {0}", dog.age);
            Console.WriteLine("Dog's age is : {0}", dog.GetAge());
            Console.WriteLine("Dog's age is : {0}", dog.MakeOlder());

            Console.WriteLine("After year the dog is {0}", dog.MakeOlder());

            //dog.MakeOlder();
            Console.WriteLine("After year the dog is {0}", dog.age);
            dog.MakeOlder();
            Console.WriteLine("After year the dog is {0}", dog.age);
        }

        //public int GetAge()
        //{
        //    return this.age;
        //}

        //public int MakeOlder()
        //{
        //    return this.age++;
        //}

        //short variant -> return without "this."
        public int GetAge()
        {
            return age;
        }

        public int MakeOlder()
        {
            return age++;
        }
    }
}
