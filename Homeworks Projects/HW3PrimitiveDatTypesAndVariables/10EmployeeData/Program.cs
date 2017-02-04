using System;

class Program
{
    static void Main()
    {
//        First name: Amanda
//Last name: Jonson
//Age: 27
//Gender: f
//Personal ID: 8306112507
//Unique Employee number: 27563571
        string name = "Amanda";
        string last = "Jonson";
        sbyte age = 27;
        char gender = 'f';
        long personalID = 8306112507;
        int employeNumber = 27563571;

        Console.WriteLine("First name : {0}", name);
        Console.WriteLine("Last name : {0}", last);
        Console.WriteLine("Age : {0}", age);
        Console.WriteLine("Gender : {0}", gender);
        Console.WriteLine("Personal ID : {0}", personalID);
        Console.WriteLine("Unique Employee number : {0}", employeNumber);
    }
}