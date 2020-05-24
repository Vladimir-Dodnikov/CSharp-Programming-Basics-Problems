using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Building
{
    class Building
    {
        static void Main(string[] args)
        {
            int floorsCount = int.Parse(Console.ReadLine());
            int roomsCount = int.Parse(Console.ReadLine());

            for (int floor = floorsCount; floor >= 1; floor--)
            {
                for (int rooms = 0; rooms < roomsCount; rooms++)
                {
                    if (floor == floorsCount)
                    {
                        Console.Write($"L{floor}{rooms} ");
                        continue;
                    }
                    if (floor % 2 == 0)
                    {
                        Console.Write($"O{floor}{rooms} ");
                    }
                    else
                    {
                        Console.Write($"A{floor}{rooms} ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
