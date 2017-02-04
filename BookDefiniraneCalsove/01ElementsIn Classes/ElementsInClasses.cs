using System;

public class Dog
{   //opening brace of the class body

    private string name;

    //constructor declaration -> CTOR
    public Dog()
    {
        this.name = null;
    }

    //another constructor declaration
    public Dog(string name)
    {
        this.name = name;
    }

    //property declaration
    public string Name
    {
        get { return Name; }
        set { name = value; }
    }

    //method declaration
    public void Bark()
    {
        Console.WriteLine("{0} said: Wow-wow!", name);
    }

    public static void Main()
    {
        string firstDogName = null;
        Console.WriteLine("Write first dog name : ");
        firstDogName = Console.ReadLine();

        //using constructr to create a dog with specified name
        Dog firstDog = new Dog(firstDogName);

        //using constructor to create dog with default name
        Dog secondDog = new Dog();

        Console.WriteLine("Write second dog name : ");
        string secondDogName = Console.ReadLine();

        //using property to set up the name of the dog
        secondDog.name = secondDogName;

        //creating dog with default name
        Dog thirdDog = new Dog();

        Dog[] dogs = new Dog[] { firstDog, secondDog, thirdDog };

        foreach (Dog dog in dogs)
        {
            dog.Bark();
        }
    }
}