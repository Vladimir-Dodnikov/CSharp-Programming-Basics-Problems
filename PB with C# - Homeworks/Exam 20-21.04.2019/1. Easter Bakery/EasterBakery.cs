using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1.Easter_Bakery
{
    class EasterBakery
    {
        static void Main(string[] args)
        {
            double priceFlourPerKG = double.Parse(Console.ReadLine());
            double kgFlour = double.Parse(Console.ReadLine());
            double kgSugar = double.Parse(Console.ReadLine());
            int barkEggsCount = int.Parse(Console.ReadLine());
            int yeastPackCount = int.Parse(Console.ReadLine());

            double priceSugarPerKG = priceFlourPerKG * 0.75;
            double priceEggsPerPack = priceFlourPerKG * 1.10;
            double priceYeastPerPack = priceSugarPerKG * 0.20;

            double sumFlour = priceFlourPerKG * kgFlour;
            double sumSugar = priceSugarPerKG * kgSugar;
            double sumEggs = barkEggsCount * priceEggsPerPack;
            double sumYeast = yeastPackCount * priceYeastPerPack;

            double totalSum = sumFlour + sumSugar + sumEggs + sumYeast;

            Console.WriteLine($"{totalSum:f2}");
        }
    }
}
