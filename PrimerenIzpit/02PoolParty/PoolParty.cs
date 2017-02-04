using System;

class PoolParty
{
    static void Main()
    {
        double V = double.Parse(Console.ReadLine());
        double p1 = double.Parse(Console.ReadLine());
        double p2 = double.Parse(Console.ReadLine());
        double hour = double.Parse(Console.ReadLine());

        //double p1Result = p1 * hour;
        //double p2Result = p2 * hour;
        double water = (p1 * hour) + (p2 * hour);

        if (V >= water)
        {
            int percentComplete = (int)((water / V) * 100);
            int p1res = (int)((p1 * hour) / water * 100);
            int p2res = (int)((p2 * hour) / water * 100);

            Console.WriteLine("The pool is {0}% full. Pipe 1: {1}%. Pipe 2: {2}%.", percentComplete, p1res, p2res);
        }
        else
        {
            //double overFlow = (hour * (p1 + p2)) - V;
            double overFlow = water - V;
            Console.WriteLine("For {0} hours the pool overflows with {1} liters.", hour, overFlow);
        }
    }
}
