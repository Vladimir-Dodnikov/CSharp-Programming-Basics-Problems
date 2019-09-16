using System;

class AlcoholMarket
{
    static void Main()
    {
        double WiskeyPrice = double.Parse(Console.ReadLine());
        double BeerQuantity = double.Parse(Console.ReadLine());
        double WineQuantity = double.Parse(Console.ReadLine());
        double RakiaQuantity = double.Parse(Console.ReadLine());
        double WiskeyQuantity = double.Parse(Console.ReadLine());
        double RakiaPrice = WiskeyPrice * 0.5;
        double BeerPrice = RakiaPrice - (0.8 * RakiaPrice);
        double WinePrice = RakiaPrice - (0.4 * RakiaPrice);
        double RakiaSum = RakiaPrice * RakiaQuantity;
        double WineSum = WinePrice * WineQuantity;
        double BeerSum = BeerQuantity * BeerPrice;
        double WiskeySum = WiskeyPrice * WiskeyQuantity;
        double TotalSum = RakiaSum + WineSum + BeerSum + WiskeySum;
        Console.WriteLine("{0:F2}", TotalSum);
    }
}