using System;

class Program
{
    static void Main()
    {
        try
        {
            uint n = uint.Parse(Console.ReadLine());
            int p = int.Parse(Console.ReadLine());
            int q = int.Parse(Console.ReadLine());
            int k = int.Parse(Console.ReadLine());

            if (Math.Max(p, q) + k - 1 > 31)
            {
                Console.WriteLine("Out of range!");
            }
            else if (Math.Min(p, q) + k - 1 >= Math.Max(p, q) + k - 1)
            {
                Console.WriteLine("Overlapping");
            }
            else
            {
                for (int i = p; i <= p + k - 1; i++)
                {
                    uint mask = 1;   // 0001;

                    uint bitQ = (n & (mask << q)) >> q; // nova promenliva koqto otpechatva maskata nalqvo s 3 pozicii i vrashta v nachalna poziciq bitovete koito shte promenqme
                    uint bitP = (n & (mask << i)) >> i; // tuk i = p ot uslovieto na cikala

                    n = n & ~(mask << i); //nullyfy  ( nalqvo s i -> pozicii
                    n = n & ~(mask << q);

                    n = n | (bitP << p); // change bitQ
                    n = n | (bitQ << i);  // change bitP

                    q++;
                }
                Console.WriteLine(n);
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("Out of range!");
        }
    }
}