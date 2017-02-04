using System;
using System.Collections.Generic;
using System.Linq;

namespace _18FoldAndSum
{
    class FoldAndSum
    {
        static void Main(string[] args)
        {
            int[] arr = Console.ReadLine().Split().Select(int.Parse).ToArray();

            int k = arr.Length / 4;
            //arr.Take(k) vzima K elementa ot masiva i gi obrushta t.e. 4 elementa v primera
            IEnumerable<int> rowLeft = arr.Take(k).Reverse();
            IEnumerable<int> rowRight = arr.Reverse().Take(k);

            //leftRow dolepya dvata oburnati kraq na masiva i gi pravi na nov masiv
            int[] leftRow = rowLeft.Concat(rowRight).ToArray();
            //vzima sredata na inputa na masiva arr kato v nachaloto skipva "K" vzima 2*k sredata i q pravi na arr
            int[] rightRow = arr.Skip(k).Take(2 * k).ToArray();

            //x sa elementite index sa broq elementi sabira vseki element ot ednata promenliva konkateniranata s sredata i poluchava rezulta
            IEnumerable<int> sumArr = leftRow.Select((x, index) => x + rightRow[index]);
            Console.WriteLine(string.Join(" ", sumArr));
        }
    }
}
