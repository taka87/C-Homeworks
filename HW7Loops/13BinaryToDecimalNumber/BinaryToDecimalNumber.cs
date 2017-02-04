using System;
//using System.Linq;

class BinaryToDecimalNumber
{
    static void Main()
    {
        string str = Console.ReadLine();

        int dec = 0;

        for (int i = 0; i < str.Length; i++)
        {
            if (str[str.Length - i - 1] == '0') continue;
            {
                dec += (int)Math.Pow(2, i); //raboti se s nai-dqsnata edinica i se raboti nalqvo ot neq 
            }
        }
        Console.WriteLine(dec);

        //        A number in any base can be thought of as the sum of its digits multiplied by their place value.For example, the decimal number 3906 can be written as:
        //3 * 1000 + 9 * 100 + 0 * 10 + 6 * 1
        //The place values are simply powers of ten:
        //3 * 10 ^ 3 + 9 * 10 ^ 2 + 0 * 10 ^ 1 + 6 * 10 ^ 0
        //(Remember that any number taken to the power of zero is 1.)
        //Binary works exactly the same way, except the base is 2, not 10.For example, the binary number 101011 can be written as:
        //1 * 2 ^ 5 + 0 * 2 ^ 4 + 1 * 2 ^ 3 + 0 * 2 ^ 2 + 1 * 2 ^ 1 + 1 * 2 ^ 0
        //I hope that gives you a better understanding of binary numbers and how to convert them.
        //On a practical note, the best solution is Matt Grande's; it's always preferable to use a library
        //method instead of rolling your own(unless you have a very good reason to do so).

    }
}