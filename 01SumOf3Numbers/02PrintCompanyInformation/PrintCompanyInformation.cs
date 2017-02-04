using System;

class PrintCompanyInformation
{
    static void Main()
    {
        //        Company name:	Software University
        //Company address:	15-18 Tintyava, Sofia
        //Phone number:	+359 899 55 55 92
        //Fax number:	
        //Web site:	http://softuni.bg

        //Manager first name:	Svetlin
        //Manager last name:	Nakov
        //Manager age:	25
        //Manager phone:	+359 2 981 981

        Console.Write("Company name:");
        string companyName = Console.ReadLine();

        Console.Write("Company address:");
        string companyAddress = Console.ReadLine();

        Console.Write("Phone number:");
        string phoneNumber = Console.ReadLine();

        Console.Write("Fax number:");
        string faxNumber = Console.ReadLine();
        if (faxNumber == "")
        {
            faxNumber = "(no fax)";
        }

        Console.Write("Web site:");
        string webSite = Console.ReadLine();

        Console.Write("Manager firs name:");
        string firstName = Console.ReadLine();

        Console.Write("Manager last name:");
        string lastName = Console.ReadLine();

        Console.Write("Manager age:");
        int age = int.Parse(Console.ReadLine());

        Console.Write("manager phone:");
        string phone = Console.ReadLine();
        Console.WriteLine();

        Console.WriteLine("{0},\nAddress : {1},\nTel. {2}\nFax. {3},\nWeb site:{4},\nManager: {5} {6} (age:{7}, tel.\n{8})",
            companyName, companyAddress, phoneNumber, faxNumber, webSite, firstName, lastName, age, phone);
    }
}