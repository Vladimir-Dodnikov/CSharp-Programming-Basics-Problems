using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AccountBalance
{
    class AccountBalance
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            double totalSum = 0.0;
            int counter = 1;

            while (counter <= n)
            {
                double currentSum = double.Parse(Console.ReadLine());
                if (currentSum < 0)
                {
                    Console.WriteLine("Invalid operation!");
                    break;
                }
                              
                Console.WriteLine($"Increase: {currentSum:f2}");
                totalSum += currentSum;
                counter++;
            }
            Console.WriteLine($"Total: {totalSum:f2}");
        }
    }
}
