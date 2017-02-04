using System;

class PlayWithIntDoubleAndString
{
    static void Main()
    {
        Console.Write("Please choose a type:\n1-- > int\n2-- > double\n3-- > string  ");

        int choice = int.Parse(Console.ReadLine());

        if (choice == 1)
        {
            Console.Write("Please enter an integer: ");
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(a + 1);
        }
        else if (choice == 2)
        {
            Console.Write("Please enter a double: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine(b + 1);
        }
        else if (choice == 3)
        {
            Console.Write("Please enter a string: ");
            string str = Console.ReadLine();

            Console.WriteLine("{0}*", str);
        }
    }
}
