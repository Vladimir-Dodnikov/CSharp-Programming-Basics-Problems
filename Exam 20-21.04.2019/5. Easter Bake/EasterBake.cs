using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5.Easter_Bake
{
    class EasterBake
    {
        static void Main(string[] args)
        {
            int easterBreadCount = int.Parse(Console.ReadLine());
            int totalSugarQuantity = 0;
            int totalFlourQuantity = 0;
            double sugarPack = 0.0;
            double flourPack = 0.0;
            int maxSugar = int.MinValue;
            int maxFlour = int.MinValue;
            for (int i = 1; i <= easterBreadCount; i++)
            {
                int sugarQuantity = int.Parse(Console.ReadLine());
                int flourQuantity = int.Parse(Console.ReadLine());

                totalSugarQuantity += sugarQuantity;
                totalFlourQuantity += flourQuantity;

                sugarPack = totalSugarQuantity / 950.0;
                flourPack = totalFlourQuantity / 750.0;

                if (sugarQuantity > maxSugar)
                {
                    maxSugar = sugarQuantity;
                }
                if (flourQuantity > maxFlour)
                {
                    maxFlour = flourQuantity;
                }
            }
            Console.WriteLine($"Sugar: {Math.Ceiling(sugarPack)}");
            Console.WriteLine($"Flour: {Math.Ceiling(flourPack)}");
            Console.WriteLine($"Max used flour is {maxFlour} grams, max used sugar is {maxSugar} grams.");
        }
    }
}
