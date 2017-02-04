using System;

class ZelenchukovaBorsa
{
    static void Main()
    {
        decimal cenaZelenchuci = decimal.Parse(Console.ReadLine());
        decimal cenaPlodove = decimal.Parse(Console.ReadLine());
        decimal kilogramiZelenchuci = decimal.Parse(Console.ReadLine());
        decimal kilogramiPlodove = decimal.Parse(Console.ReadLine());

        decimal result = ((cenaZelenchuci * kilogramiZelenchuci) + (cenaPlodove * kilogramiPlodove)) / 1.94m;

        Console.WriteLine(result);
    }
}
