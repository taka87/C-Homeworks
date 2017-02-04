using System;

class FormattingNumbers
{
    static void Main()
    {
        int a = int.Parse(Console.ReadLine());
        if (a>500||a<0)
        {
            Console.WriteLine("Invalid input:");
            return;
        }
        double b = double.Parse(Console.ReadLine());
        string binaryNum = Convert.ToString(a,2).PadLeft(10,'0'); //padleft->
        //-> dobavq '0' na mqstoto akdeto ima prazen interval

        double c = double.Parse(Console.ReadLine());    

        string aValue = a.ToString("X");
        //        Console.Write(Convert.ToString(a, 2).PadLeft(10,'0'));
        Console.Write("|{0,-10}|{1,10}|{2,10:F1}|{3,-10:F3}|",
            aValue, binaryNum,b, c);

    }
}