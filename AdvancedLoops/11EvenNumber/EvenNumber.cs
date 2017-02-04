using System;

class EvenNumber
{
    static void Main()
    {
        for (int j = 0; j < 100000; j++)
        {
            try
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.Write("Enter even number: ");
                    int n = int.Parse(Console.ReadLine());

                    if (n % 2 != 0)
                    {
                        Console.WriteLine("The number is not even.");
                        continue;
                    }
                    else
                    {
                        Console.WriteLine("Even number entered: {0}", n);
                        break;
                    }
                }
            }
            catch (Exception)
            {
                Console.WriteLine("The number is not even.");
                continue;
            }
            break;
        }
    }
}