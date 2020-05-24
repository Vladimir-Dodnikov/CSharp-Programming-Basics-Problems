using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Income_Stadium
{
    class IncomeStadium
    {
        static void Main(string[] args)
        {
            int sectorsCount = int.Parse(Console.ReadLine());
            int capacityStadium = int.Parse(Console.ReadLine());
            double ticketPrice = double.Parse(Console.ReadLine());

            var totalIncome = capacityStadium * ticketPrice;
            var incomeOneSector = totalIncome / sectorsCount;
            var moneyForCharity = (totalIncome - (0.75*incomeOneSector)) / 8.0;

            Console.WriteLine($"Total income - {totalIncome:f2} BGN");
            Console.WriteLine($"Money for charity - {moneyForCharity:f2} BGN");
        }
    }
}
