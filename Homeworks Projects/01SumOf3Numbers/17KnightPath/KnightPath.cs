using System;

class KnightPath
{
    static void Main(string[] args)
    {
        int[] table = new int[8];

        int rowPos = 0;
        int colPos = 0;

        table[0] = 1;

        string command = Console.ReadLine();

        while (command != "stop")
        {
            int nextRow = -1;
            int nextCol = -1;

            string[] directionData = command.Split();

            switch (directionData[0])
            {
                case "up":
                    nextRow = rowPos - 2;
                    break;
                case "down":
                    nextRow = rowPos + 2;
                    break;
                case "left":
                    nextCol = colPos + 2;
                    break;
                case "right":
                    nextCol = colPos - 2;
                    break;
            }
            switch (directionData[1])
            {
                case "up":
                    nextRow = rowPos - 1;
                    break;
                case "down":
                    nextRow = rowPos + 1;
                    break;
                case "left":
                    nextCol = colPos + 1;
                    break;
                case "right":
                    nextCol = colPos - 1;
                    break;
            }
            if (0 <= nextRow && nextRow <= 7 && 0 <= nextCol && 7 >= nextCol)
            {
                rowPos = nextRow;
                colPos = nextCol;

                table[rowPos] ^= (1 << colPos);
            }
            command = Console.ReadLine();
        }
        bool isZeroBoard = true;

        foreach (var number in table)
        {
            if (number!=0)
            {
                Console.WriteLine(number);
                isZeroBoard = false;
            }
        }
        if (isZeroBoard)
        {
            Console.WriteLine("[Board is empty]");
        }
    }
}