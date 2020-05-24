using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BestPlayer
{
    class BestPlayer
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            int maxGoals = 0;
            int goals = 0;
            string bestPlayer = string.Empty;
            bool isHattrick = false;

            while (name != "END")
            {
                goals = int.Parse(Console.ReadLine());
                if (goals > maxGoals)
                {
                    maxGoals = goals;
                    bestPlayer = name;
                }
                if (goals >= 3)
                {
                    isHattrick = true;
                }
                if (goals >= 10)
                {
                    break;
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"{bestPlayer} is the best player!");

            if (isHattrick)
            {
                Console.WriteLine($"He has scored {maxGoals} goals and made a hat-trick !!!");
            }
            else
            {
                Console.WriteLine($"He has scored {maxGoals} goals.");
            }
        }
    }
}
