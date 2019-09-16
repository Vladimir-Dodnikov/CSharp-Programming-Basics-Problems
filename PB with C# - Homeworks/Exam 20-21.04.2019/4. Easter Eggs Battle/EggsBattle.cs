using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4.Easter_Eggs_Battle
{
    class EggsBattle
    {
        static void Main(string[] args)
        {
            int eggsCountFirst = int.Parse(Console.ReadLine());
            int eggsCountSecond = int.Parse(Console.ReadLine());
            string command = string.Empty;
            while ((command = Console.ReadLine()) != "End of battle")
            {
                if (command == "End of battle")
                {
                    break;
                }
                if (command == "one")
                {
                    eggsCountSecond -= 1;
                }
                else if (command == "two")
                {
                    eggsCountFirst -= 1;
                }
                if (eggsCountFirst == 0)
                {
                    break;
                }
                else if (eggsCountSecond == 0)
                {
                    break;
                }
            }
            if (eggsCountFirst == 0)
            {
                Console.WriteLine($"Player one is out of eggs. Player two has {eggsCountSecond} eggs left.");
            }
            else if (eggsCountSecond == 0)
            {
                Console.WriteLine($"Player two is out of eggs. Player one has {eggsCountFirst} eggs left.");
            }
            if (command == "End of battle")
            {
                Console.WriteLine($"Player one has {eggsCountFirst} eggs left.");
                Console.WriteLine($"Player two has {eggsCountSecond} eggs left.");
            }
        }
    }
}
