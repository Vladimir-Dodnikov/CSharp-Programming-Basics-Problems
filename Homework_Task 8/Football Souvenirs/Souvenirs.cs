using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Football_Souvenirs
{
    class Souvenirs
    {
        static void Main(string[] args)
        {
            string team = Console.ReadLine();
            string souvenirs = Console.ReadLine();
            int souvenirsCount = int.Parse(Console.ReadLine());
            double price = 0;
            if (team == "Argentina")
            {
                if (souvenirs == "flags")
                {
                    price = 3.25;
                }
                else if (souvenirs == "caps")
                {
                    price = 7.20;
                }
                else if (souvenirs == "posters")
                {
                    price = 5.10;
                }
                else if (souvenirs == "stickers")
                {
                    price = 1.25;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (team == "Brazil")
            {
                if (souvenirs == "flags")
                {
                    price = 4.20;
                }
                else if (souvenirs == "caps")
                {
                    price = 8.50;
                }
                else if (souvenirs == "posters")
                {
                    price = 5.35;
                }
                else if (souvenirs == "stickers")
                {
                    price = 1.20;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (team == "Croatia")
            {
                if (souvenirs == "flags")
                {
                    price = 2.75;
                }
                else if (souvenirs == "caps")
                {
                    price = 6.90;
                }
                else if (souvenirs == "posters")
                {
                    price = 4.95;
                }
                else if (souvenirs == "stickers")
                {
                    price = 1.10;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else if (team == "Denmark")
            {
                if (souvenirs == "flags")
                {
                    price = 3.10;
                }
                else if (souvenirs == "caps")
                {
                    price = 6.50;
                }
                else if (souvenirs == "posters")
                {
                    price = 4.80;
                }
                else if (souvenirs == "stickers")
                {
                    price = 0.90;
                }
                else
                {
                    Console.WriteLine("Invalid stock!");
                    return;
                }
            }
            else
            {
                Console.WriteLine("Invalid country!");
                return;
            }
            double totalPrice = price * souvenirsCount;
            Console.WriteLine($"Pepi bought {souvenirsCount} {souvenirs} of {team} for {totalPrice:f2} lv.");
        }
    }
}
