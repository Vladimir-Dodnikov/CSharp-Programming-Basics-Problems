using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int max =int.MinValue;
            while (counter < n)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                counter++;
                if (currentNumber > max)
                {
                    max = currentNumber;
                }
            }
            Console.WriteLine(max);
        }
    }
}
