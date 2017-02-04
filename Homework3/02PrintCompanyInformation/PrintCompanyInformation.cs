using System;

class PrintCompanyInformation
{
    static void Main()
    {
        Console.Write("Company name: ");
        string company = Console.ReadLine();
        Console.Write("Company address: ");
        string adress = Console.ReadLine();
        Console.Write("Company number: ");
        string number = Console.ReadLine();
        Console.Write("Fax number: ");
        string fax = Console.ReadLine();
        Console.Write("Web site:");
        string web = Console.ReadLine();
        Console.Write("Manager first name: ");
        string manager = Console.ReadLine();
        Console.Write("Manager last name: ");
        string last = Console.ReadLine();
        Console.Write("Manager Age: ");
        string age = Console.ReadLine();
        Console.Write("Manager phone:");
        string phone = Console.ReadLine();

        Console.WriteLine(company);
        Console.WriteLine("Address: {0}", adress);
        Console.WriteLine("Tel :", number);
        Console.Write("Fax : ");
        if (fax == string.Empty)
        {
            Console.WriteLine("(no fax)");
        }
        else
        {
            Console.WriteLine("{0}", fax);
        }
        Console.WriteLine("Web site : {0}", web);
        Console.Write("Manager first name: ", manager + " " + last);
        Console.WriteLine("Age : " + age + ", tel. " + phone);
    }
}

