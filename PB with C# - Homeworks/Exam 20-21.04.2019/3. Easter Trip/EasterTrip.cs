using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3.Easter_Trip
{
    class EasterTrip
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();
            string reservedDate = Console.ReadLine();
            int nightCount = int.Parse(Console.ReadLine());
            int totalPrice = 0;

            if (destination == "France")
            {
                if (reservedDate == "21-23")
                {
                    totalPrice = nightCount * 30;
                }
                else if (reservedDate == "24-27")
                {
                    totalPrice = nightCount * 35;
                }
                else if (reservedDate == "28-31")
                {
                    totalPrice = nightCount * 40;
                }
            }
            else if (destination == "Italy")
            {
                if (reservedDate == "21-23")
                {
                    totalPrice = nightCount * 28;
                }
                else if (reservedDate == "24-27")
                {
                    totalPrice = nightCount * 32;
                }
                else if (reservedDate == "28-31")
                {
                    totalPrice = nightCount * 39;
                }
            }
            else if (destination == "Germany")
            {
                if (reservedDate == "21-23")
                {
                    totalPrice = nightCount * 32;
                }
                else if (reservedDate == "24-27")
                {
                    totalPrice = nightCount * 37;
                }
                else if (reservedDate == "28-31")
                {
                    totalPrice = nightCount * 43;
                }
            }
            Console.WriteLine($"Easter trip to {destination} : {totalPrice:f2} leva.");
        }
    }
}
