using System;

class ExerciseWithString
{
    static void Main()
    {
        int num = 5;
        string str = "num =           " + num.ToString();
        Console.WriteLine(str);

        int num1 = 5;
        string newStr = string.Format("num = {0} :P", num1);
        Console.WriteLine(newStr);

        int num2 = 5;
        string newStr1 = $"num = {num2}!";
        Console.WriteLine(newStr1);

    }
}