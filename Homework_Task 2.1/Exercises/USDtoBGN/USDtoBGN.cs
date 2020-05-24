using System;

    class USDtoBGN
    {
        static void Main()
        {
            double USD = double.Parse(Console.ReadLine());
            double usdTobgn = 1.79549;
            double BGN = USD * usdTobgn;
            Console.WriteLine("{0:F2} BGN", BGN);
        }
    }
