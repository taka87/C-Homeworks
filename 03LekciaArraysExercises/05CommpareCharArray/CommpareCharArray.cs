using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05CommpareCharArray
{
    class CommpareCharArray
    {
        static void Main(string[] args)
        {
            //char[] arr1 = Console.ReadLine().Split().Select(char.Parse).ToArray();
            //char[] arr2 = Console.ReadLine().Split().Select(char.Parse).ToArray();

            //int counter = Math.Min(arr1.Length, arr2.Length);
            //bool isFirst = false;

            //for (int i = 0; i < counter; i++)
            //{
            //    if (arr1[i] < arr2[i])
            //    {
            //        isFirst = true;
            //        break;
            //    }
            //}

            //if (isFirst)
            //{
            //    Console.WriteLine(string.Join("", arr2));
            //    Console.WriteLine(string.Join("", arr1));
                
            //}
            //else
            //{
            //    Console.WriteLine(string.Join("", arr1));
            //    Console.WriteLine(string.Join("", arr2));
                
            //}

            char[] a = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            char[] b = Console.ReadLine().Split(' ').Select(char.Parse).ToArray();
            string[] ab = { new string(a), new string(b) };

            Console.WriteLine(string.Join("\n", ab.OrderBy(str => str)));
        }
    }
}
