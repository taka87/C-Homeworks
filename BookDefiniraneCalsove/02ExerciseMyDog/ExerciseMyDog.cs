using System;

namespace _02ExerciseMyDog
{
    public class Dog
    {
        //string name;
        //int age;
        //int lenght;
        //bool isMale;

        string name = "Alexandra";
        int age = 25;
        int lenght = 11;
        bool isMale = true;

        static void Main(string[] args)
        {
            Dog dog = new Dog();

            //dava nqkakvi stranni error za tova che sa deklarirani prazni promenlivi
            Console.WriteLine("Dog name is : {0}", dog.name);
            Console.WriteLine("Dog name is : {0}", dog.age);
            Console.WriteLine("Dog name is : {0}", dog.lenght);
            Console.WriteLine("Dog name is : {0}", dog.isMale);
        }
    }
}
