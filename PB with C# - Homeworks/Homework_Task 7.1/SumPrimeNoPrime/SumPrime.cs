using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumPrimeNoPrime
{
    class SumPrime
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int sumPrime = 0;
            int sumNoPrime = 0;

            while (input != "stop")
            {
                int num = int.Parse(input);
                bool isPrime = true;
                                
                if (num < 0)
                {
                    Console.WriteLine("Number is negative.");
                    input = Console.ReadLine();
                    continue;
                }
                if (num == 1)
                {
                    isPrime = false;
                }
                else
                {
                    for (int i = num; i >= 2; i--)
                    {
                        if (num % i == 0 && i != num)
                        {
                            isPrime = false;
                            break;
                        }
                    }
                }
                if (isPrime)
                {
                    sumPrime += num;
                }
                else
                {
                    sumNoPrime += num;
                }
                input = Console.ReadLine();
            }
            Console.WriteLine($"Sum of all prime numbers is: {sumPrime}");
            Console.WriteLine($"Sum of all non prime numbers is: {sumNoPrime}");
        }
    }
}
