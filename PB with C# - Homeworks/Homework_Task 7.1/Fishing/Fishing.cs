using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fishing
{
    class Fishing
    {
        static void Main(string[] args)
        {
            int dayQuata = int.Parse(Console.ReadLine());
            int dayQuataCounter = 0;
            string fishName = string.Empty;
            double profit = 0;
            while (fishName != "Stop")
            {
                fishName = Console.ReadLine();
                if (fishName == "Stop")
                {
                    break;
                }

                double fishKilograms = double.Parse(Console.ReadLine());
                double price = 0;
                for (int i = 0; i < fishName.Length; i++)
                {
                    price += fishName[i];
                }

                price = price / fishKilograms;
                dayQuataCounter++;
                if (dayQuataCounter% 3 == 0)
                {
                    profit += price;
                }
                else
                {
                    profit -= price;
                }
                if (dayQuataCounter == dayQuata)
                {
                    Console.WriteLine("Lyubo fulfilled the quota!");
                    break;
                }
            }
            if (profit > 0)
            {
                Console.WriteLine($"Lyubo's profit from {dayQuataCounter} fishes is {profit:f2} leva.");
            }
            else if (profit < 0 )
            {
                Console.WriteLine($"Lyubo lost {Math.Abs(profit):f2} leva today.");
            }
        }
    }
}
