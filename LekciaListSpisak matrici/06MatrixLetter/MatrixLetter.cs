using System;

class MatrixLetter
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        char symbol = 'A';

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(symbol + " ");
                symbol++;
            }
            Console.WriteLine();
        }
    }
}