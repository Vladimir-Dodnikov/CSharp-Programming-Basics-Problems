using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cake2
{
    class Cake2
    {
        static void Main(string[] args)
        {
            int widthCake = int.Parse(Console.ReadLine());
            int lengthCake = int.Parse(Console.ReadLine());
            int cake = widthCake * lengthCake;

            while (cake >= 0)
            {
                string current = Console.ReadLine();
                if (current == "STOP")
                {
                    break;
                }
                int pieces = int.Parse(current);
                cake -= pieces;
                
            }
            if (cake >= 0)
            {
                Console.WriteLine("{0} pieces are left.", cake);
            }
            else
            {
                Console.WriteLine($"No more cake left! You need {Math.Abs(cake)} pieces more.");
            }
        }
    }
}
