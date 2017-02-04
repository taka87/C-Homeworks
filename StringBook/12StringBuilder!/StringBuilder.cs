using System;
using System.Text;

namespace _12StringBuilder_
{
    class StringBuilder
    {
        static void Main(string[] args)
        {
            string text = "EM edit";
            string reversed = ReversedText(text);
            Console.WriteLine(reversed);
        }

        private static string ReversedText(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                //neche da raboti
                //sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}
