using System;

class ConditionalStatementsExercises
{
    static void Main()
    {
        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        //int result1 = 1;
        //int result2 = 1;
        //int result3 = 1;


        //if (a >= 0)
        //{
        //    result1 = 1;
        //}
        //else
        //{
        //    result1 = 0;
        //}
        //if (b >= 0)
        //{
        //    result2 = 1;
        //}
        //else
        //{
        //    result2 = 0;
        //}
        //if (c >= 0)
        //{
        //    result3 = 1;
        //}
        //else
        //{
        //    result3 = 0;
        //}

        //int result = result1 + result2 + result3;

        //// Console.WriteLine(result);

        //switch (result)
        //{
        //    case 1:
        //    case 3:
        //        Console.WriteLine("Positive");
        //        break;
        //    default:
        //        Console.WriteLine("Negative");
        //        break;
        //}

        int countNegative = 0;
        if (a >= 0)
        {
            countNegative++;
        }
        if (b >= 0)
        {
            countNegative++;
        }
        if (c >= 0)
        {
            countNegative++;
        }
        if (countNegative % 2 == 0)
        {
            Console.WriteLine("Positive");
        }
        else
        {
            Console.WriteLine("Negative");
        }

    }
}

