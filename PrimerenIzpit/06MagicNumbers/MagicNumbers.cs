using System;
class MagicNumbers
{
    static void Main()
    {
        int num = int.Parse(Console.ReadLine());

        for (int i = 1; i < 10; i++)
        {
            for (int j = 1; j < 10; j++)
            {
                for (int k = 1; k < 10; k++)
                {
                    for (int l = 1; l < 10; l++)
                    {
                        for (int m = 1; m < 10; m++)
                        {
                            for (int n = 1; n < 10; n++)
                            {
                                if ((i * j * k * l * m * n) == num)
                                {
                                    Console.Write("{0}{1}{2}{3}{4}{5} ", i, j, k, l, m, n);
                                }
                            }
                        }
                    }
                }
            }
        }
    }
}