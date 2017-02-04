using System;

class EmployeeData
{
    static void Main()
    {

        Console.Write("Enter first name : ");
        string name = Console.ReadLine();
        Console.Write("Enter Last name : ");
        string last = Console.ReadLine();
        Console.Write("Enter age : ");
        string age = Console.ReadLine();
        Console.Write("Enter gender M or F : ");
        string gender = Console.ReadLine();
        Console.Write("Enter Personal ID number(e.g. 0000000000): ");
        string personalID = Console.ReadLine();
        Console.Write("Unique employee number(27560000…27569999 : ");
        string employee = Console.ReadLine();

        Console.WriteLine(name);
        Console.WriteLine(last);
        Console.WriteLine(age);
        Console.WriteLine(gender);
        Console.WriteLine(personalID);
        Console.WriteLine(employee);

    }
}

