using System;

class ConditionalStatementsExercises
{
    static void Main()
    {
        int first = int.Parse(Console.ReadLine());
        int second = int.Parse(Console.ReadLine());
        int thirt = int.Parse(Console.ReadLine());

        if (first > second && first > thirt)
        {
            Console.WriteLine(first);
        }
        else if (first < second && second > thirt)
        {
            Console.WriteLine(second);
        }
        else
        {
            Console.WriteLine(thirt);
        }
    }
}

