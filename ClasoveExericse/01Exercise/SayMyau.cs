using System;

namespace _01Exercise
{
    public class Cat
    {
        private string name;

        private string color;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public Cat()
            {
            this.name = "Unamed";
            this.color = "gray";
            }
        public Cat(string name, string color)
        {
            this.name = name;
            this.color = color;
        }
        //method sayMyau
        public void SayMyau()
        {
            Console.WriteLine("Cat {0} said: Miyauuuuuu!", name);
        }
    }
    class SayMyau
    {
        static void Main(string[] args)
        {
            Cat firstCat = new Cat();
            firstCat.Name = "Tonito";
            firstCat.SayMyau();

            Cat secondCat = new Cat("Pepy", "Red");
            secondCat.SayMyau();
            Console.WriteLine("Cat {0} is {1}", secondCat.Name, secondCat.Color);

            Console.WriteLine();
            Cat myCat = new Cat();
            myCat.Name = "Tomhasan";
            Console.WriteLine($"My cat's name is {myCat.Name} - toi e Pelence");
            Console.Write("My ");
            myCat.SayMyau();

            //Priema prazen argument v metoda
            Console.WriteLine();
            Console.WriteLine("New Exercise");
            Cat newCatSomecat = new Cat();
            Console.WriteLine("The color of the cat {0} is {1}", newCatSomecat.Name, newCatSomecat.Color);
            newCatSomecat.SayMyau();

            //priema zadadeniq argument v metoda
            Cat newMyCat = new Cat("Tomi Hasan", "white");
            Console.WriteLine("The color of the cat {0} is {1}", newMyCat.Name, newMyCat.Color);
            newMyCat.SayMyau();
        }
    }
}