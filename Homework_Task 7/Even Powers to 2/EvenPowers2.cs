using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Even_Powers_to_2
{
    class EvenPowers2
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            for (int i = 0; i <= n; i+=2)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
