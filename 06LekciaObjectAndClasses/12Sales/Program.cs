using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _12Sales
{
    class Program
    {
        static void Main(string[] args)
        {
            //    List<Sale> sales = new List<Sale>();
            //    int numbersOfSales = int.Parse(Console.ReadLine());

            //    for (int i = 0; i < numbersOfSales; i++)
            //    {
            //        string[] saleParam = Console.ReadLine().Split();

            //        Sale sale = new Sale()
            //        {
            //            Town = int.Parse(saleParam[0]);
            //        Product = int.Parse(saleParam[1]);
            //        Price = decimal.Parse(saleParam[2]);
            //        Quantity = double.Parse(saleParam[3]);
            //    };

            //}
            //sales.Add(sale);
            //}
            //List<string> towns = Sale.sale(x => x.Town).Distinct()().OrderBy(x => x).ToList();

            //foreach (var town in towns)
            {
                // decimal townRevenue = sales.Where(_12Sales => Sale.Town == town).Select

            }
        }

        public class Sale
        {
            public int Town { get; set; }
            public string Product { get; set; }
            public decimal Price { get; set; }
            public int Quantity { get; set; }

            public decimal Revenue()
            {
                return Price * (decimal)Quantity;
            }
        }
    }
}