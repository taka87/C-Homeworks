using System;

    class QuadraticEquation
    {
        static void Main()
        {
        float a = float.Parse(Console.ReadLine());
        float b = float.Parse(Console.ReadLine());
        float c = float.Parse(Console.ReadLine());

        //float sum = (b * b) - (4 * a * c);

        double D = Math.Sqrt(Math.Pow(b, 2) - 4 * a * c);
        if (D > 0 && a != 0)
        {
            Console.WriteLine("x1={0}; x2={1}", (-b + D) / (2.0 * a), (-b - D) / (2.0 * a));
        }
        else if (D == 0 && a != 0)
        {
            Console.WriteLine("x1=x2={0}", -b / (2.0 * a));
        }
        else
        {
            Console.WriteLine("no real roots");
        }

    }
}

