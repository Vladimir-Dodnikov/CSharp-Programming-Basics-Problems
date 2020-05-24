using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2.EasterGuest
{
    class EasterGuest
    {
        static void Main(string[] args)
        {
            int guestCount = int.Parse(Console.ReadLine());
            int budget = int.Parse(Console.ReadLine());

            double easterBreadCount = Math.Ceiling(guestCount / 3.0);
            int eggsCount = guestCount * 2;
            double priceEasterBread = easterBreadCount * 4;
            double priceEggs = eggsCount * 0.45;
            double totalPrice = priceEasterBread + priceEggs;

            if (totalPrice <= budget)
            {
                var left = budget - totalPrice;
                Console.WriteLine($"Lyubo bought {easterBreadCount} Easter bread and {eggsCount} eggs.");
                Console.WriteLine($"He has {left:f2} lv. left.");
            }
            else
            {
                var needed = totalPrice - budget;
                Console.WriteLine($"Lyubo doesn't have enough money.");
                Console.WriteLine($"He needs {needed:f2} lv. more.");
            }
        }
    }
}
