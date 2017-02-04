using System;

class BitsExchange
{
    static void Main()
    {
        uint n = uint.Parse(Console.ReadLine());
        uint mask = 7;   // 0111;

        uint firstBits = (n & (mask << 3)) >> 3; // nova promenliva koqto otpechatva maskata nalqvo s 3 pozicii i vrashta v nachalna poziciq bitovete koito shte promenqme
        uint secondtBits = (n & (mask << 24)) >> 24;

        n = n & ~(mask << 3); // premestva se veche promenenata maska na tochnoto mqsto
        n = n & ~(mask << 24);

        n = n | (firstBits << 24); // vrashta se ostanalata chast ot chisloto na mqstoto si
        n = n | (secondtBits << 3);

        Console.WriteLine(n);
    }
}