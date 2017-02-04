using System;
using System.Linq;

class CountLettersInString
{
    static void Main()
    {
        string str = Console.ReadLine().ToLower();

        int[] count = new int[str.Max() + 1];

        foreach (char ch in str)                    //vzima vsicki charcheta ot masiva i gi palni v otdelnite simvoli v tablicata
        {
            count[ch]++;
        } 

        for (char ch = (char)0; ch < count.Length; ch++)              // obikalya vsichki simvoli i koito sa napalneni gi otpechatva
        {                                                              // zaedno s tezi koito sa se napalnili s opredeleni broiki
            if (count[ch] != 0)      // count[ch] proveryqva vseki realen simvol i go otpechatva kadeto ima napalneno
            {
                Console.WriteLine($"{ch} -> {count[ch]}");
            }
        }
    }
}