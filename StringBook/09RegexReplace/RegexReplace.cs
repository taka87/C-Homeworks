using System;
using System.Text.RegularExpressions;

namespace _09RegexReplace
{
    class RegexReplace
    {
        static void Main(string[] args)
        {
            string someDocs = "Smith's number: 0898880022\nFranky can be " +
                " found at 0888445566.\nSteven’ mobile number: 0887654321";

            string replaceDoc = Regex.Replace(someDocs, "(08)[0-9]{8}", "$1***********");  //zamenq zapochvashtite s konst 08->
            //-> s cifrite vklyuchvashti ot 0-9, tochno 8 simvola nazad zamenq 
            string replaceDoc1 = Regex.Replace(someDocs, "(08)[0-7]{8}", "$1******");
            string replaceDoc2 = Regex.Replace(someDocs, "(08)[0-5]{4}", "$1***");
            string replaceDoc3 = Regex.Replace(someDocs, "(09)[0-7]{5}", "$1******");

            Console.WriteLine(replaceDoc);
            Console.WriteLine();
            Console.WriteLine(replaceDoc1);  // not working
            Console.WriteLine();
            Console.WriteLine(replaceDoc2); // not working
            Console.WriteLine();
            Console.WriteLine(replaceDoc3); // not working
        }
    }
}
