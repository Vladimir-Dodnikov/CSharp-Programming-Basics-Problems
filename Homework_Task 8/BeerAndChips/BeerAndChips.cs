using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeerAndChips
{
    class BeerAndChips
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double budget = double.Parse(Console.ReadLine());
            int beerCount = int.Parse(Console.ReadLine());
            int chipsCount = int.Parse(Console.ReadLine());

            double beerPrice = beerCount * 1.20;
            double chipsPrice = Math.Ceiling(beerPrice * 0.45 * chipsCount);
            double totalPrice = beerPrice + chipsPrice;
            double moneyLeft = budget - totalPrice;
            if (totalPrice <= budget)
            {
                Console.WriteLine($"{name} bought a snack and has {moneyLeft:f2} leva left.");
            }
            else
            {
                Console.WriteLine($"{name} needs {Math.Abs(moneyLeft):f2} more leva!");
            }
        }
    }
}
