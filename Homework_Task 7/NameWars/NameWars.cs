using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NameWars
{
    class NameWars
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();

            int maxValue = int.MinValue;        //za da pazim porednata suma do poluchavaneto na po-golqma
            string winner = string.Empty;

            while (name != "STOP")
            {
                int sumOfChar = 0;
                for (int letter = 0; letter < name.Length; letter++)
                {
                    int letterValue = (int)(name[letter]);
                    sumOfChar += letterValue;
                    if (sumOfChar > maxValue)
                    {
                        maxValue = sumOfChar;
                        winner = name;
                    }
                }
                name = Console.ReadLine();
            }
            Console.WriteLine($"Winner is {winner} - {maxValue}!");
        }
    }
}
