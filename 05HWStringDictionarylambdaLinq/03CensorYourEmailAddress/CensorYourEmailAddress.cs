using System;

namespace _03CensorYourEmailAddress
{
    class CensorYourEmailAddress
    {
        static void Main(string[] args)
        {
            string email = Console.ReadLine();
            string text = Console.ReadLine();

            string[] partsOfEmail = email.Split('@');
            string username = partsOfEmail[0];
            string domain = partsOfEmail[1];
            string replacement = new string('*', username.Length) + "@" + domain;

            text = text.Replace(email, replacement);
            Console.WriteLine(text);

            ////Zamenq vsichkite s mail a to v uslovieto se iska da zameni tam kadeto ne e NOT
            //string[] mail = Console.ReadLine().Split('@');
            //string input = Console.ReadLine();
            //string username = mail[0];

            //char[] asterix = new char[username.Length];

            //for (int i = 0; i < asterix.Length; i++)
            //{
            //    asterix[i] = '*';
            //}


            //string output = input.Replace(username,string.Join("",asterix));

            //Console.WriteLine(output);
        }
    }
}
