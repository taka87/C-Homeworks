using System;

class MatrixLetter
{
    static void Main()
    {
        int rows = int.Parse(Console.ReadLine());
        int cols = int.Parse(Console.ReadLine());

        string[,] arr = new string[rows, cols];

        for (int i = 0; i < rows; i++)
        {
            string inputRow = Console.ReadLine();
            string[] inputCols = inputRow.Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
            for (int j = 0; j < cols; j++)
            {
                arr[i, j] = inputCols[j];    // arr[i, j] = int.Parse(inputCols[j]);
            }           
        }
        for (int i = 0; i < cols; i++)
        {
           for (int j = 0; j < rows; j++)
            {
                Console.Write(arr[rows-j-1, i] + " ");
            }
            Console.WriteLine();
        }
    }
}