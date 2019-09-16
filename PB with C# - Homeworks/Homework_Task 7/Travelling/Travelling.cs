using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Travelling
{
    class Travelling
    {
        static void Main(string[] args)
        {
            string destination = Console.ReadLine();

            while (destination != "End")
            {
                double neededSum = double.Parse(Console.ReadLine());
                double savedMoney = 0;
                while (savedMoney < neededSum)
                {
                    double currentMoney = double.Parse(Console.ReadLine());
                    savedMoney += currentMoney;
                }
                if (savedMoney >= neededSum)
                {
                    Console.WriteLine($"Going to {destination}!");
                    savedMoney = 0;
                    destination = Console.ReadLine();
                }
                if (destination == "End")
                {
                    break;
                }
            }
        }
    }
}
