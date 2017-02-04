using System;

class NumberTable
{
    static void Main()
    {
        //int n = int.Parse(Console.ReadLine());

        //int num = 0;
        //for (int row = 0; row < n; row++)
        //{
        //    for (int col = 0; col < n; col++)
        //    {

        //        if (col <= (n / 2))
        //        {
        //            num = row + col + 1;
        //            Console.Write(num + " ");
        //        }
        //        else
        //        {
        //            num = 2 * n - num-1;
        //            Console.Write(num + " ");
        //        }


        //    }
        //    Console.WriteLine();
        //}
     
        int n = int.Parse(Console.ReadLine());
        int num;
        bool direction = true;
        for (int i = 1; i <= n; i++)
        {
            num = i;
            direction = true;
            for (int j = 0; j < n; j++)
            {
                Console.Write(num + " ");
                if (num == n)
                    direction = !direction;
                if (direction)
                    num++;
                else
                    num--;
            }
            Console.WriteLine();
        }
    }
}