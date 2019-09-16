using System;

    class TailloringWorkshop
    {
        static void Main()
        {
            int Tables = int.Parse(Console.ReadLine());
            double Length = double.Parse(Console.ReadLine());
            double Width = double.Parse(Console.ReadLine());

            double AreaCovers = 
                Tables * (Length + 2 * 0.30) * (Width + 2 * 0.30);
            double AreaSquares = Tables * (Length / 2) * (Length / 2);

            double PriceInDollars = AreaCovers * 7 + AreaSquares * 9;
            double PriceInLevs = PriceInDollars * 1.85;

            Console.WriteLine("{0:F2} USD", PriceInDollars);
            Console.WriteLine("{0:F2} BGN", PriceInLevs);
        }
    }
