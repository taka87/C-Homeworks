using System;

class NumberFeom1To100
{
    static void Main()
    {
        int counter = 1;

        for (int i = 0; i < counter; i++)
        {
            Console.Write("Enter a number in the range [1...100]: ");
            int n = int.Parse(Console.ReadLine());

            if (n <= 100 && n > 0)
            {
                Console.WriteLine("The number is: {0}", n);
                break;
            }
            else
            {
                Console.WriteLine("Invalid number!");
                counter++;
            }
        }
    }
}