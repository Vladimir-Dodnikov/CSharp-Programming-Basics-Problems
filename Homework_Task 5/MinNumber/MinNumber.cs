using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinNumber
{
    class MinNumber
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int counter = 0;
            int min= int.MaxValue;
            while (counter < n)
            {
                int currentNumber = int.Parse(Console.ReadLine());
                counter++;
                if (currentNumber < min)
                {
                    min = currentNumber;
                }
            }
            Console.WriteLine(min);
        }
    }
}
