using System;

class Program
{
    static void Main()
    {
        double priceUS = double.Parse(Console.ReadLine());
        double weightUS = double.Parse(Console.ReadLine());
        double priceUK = double.Parse(Console.ReadLine());
        double weightUK = double.Parse(Console.ReadLine());
        double priceCH = double.Parse(Console.ReadLine());
        double weightCH = double.Parse(Console.ReadLine());

        double sumUS = (priceUS / 0.58) / weightUS;
        double sumUK = (priceUK / 0.41) / weightUK;
        double sumCH = (priceCH * 0.27) / weightCH;

        if (sumUS < sumUK && sumUS < sumCH)
        {
            Console.WriteLine($"US store. {sumUS:f2} lv/kg");
            if (sumUK > sumCH)
            {
                Console.WriteLine("Difference {0:f2} lv/kg", sumUK - sumUS);
            }
            else
            {
                Console.WriteLine("Difference {0:f2} lv/kg", sumCH - sumUS);
            }
        }
        else if (sumUK < sumUS && sumUK < sumCH)
        {
            Console.WriteLine($"UK store. {sumUK:f2} lv/kg");
            if (sumUS > sumCH)
            {
                Console.WriteLine("Difference {0:f2} lv/kg", sumUS - sumUK);
            }
            else
            {
                Console.WriteLine("Difference {0:f2} lv/kg", sumCH - sumUK);
            }
        }
        else
        {
            Console.WriteLine($"Chinese store. {sumCH:f2} lv/kg");
            if (sumUS > sumUK)
            {
                Console.WriteLine("Difference {0:f2} lv/kg", sumUS - sumCH);
            }
            else
            {
                Console.WriteLine("Difference {0:f2} lv/kg", sumUK - sumCH);
            }
        }

        Console.WriteLine(sumUS);
        Console.WriteLine(sumUK);
        Console.WriteLine(sumCH);
    }
}