using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding
{
    class Coding
    {
        static void Main(string[] args)
        {
            string inputNum = Console.ReadLine();
            for (int i = inputNum.Length - 1; i >= 0; i--)
            {
                char currentChar = inputNum[i];
                int currentCharToNumber = int.Parse(currentChar.ToString());
                if (currentCharToNumber == 0)
                {
                    Console.WriteLine("ZERO");
                    continue;
                }
                for (int n = 1; n <= currentCharToNumber; n++)
                {
                    Console.Write((char)(currentCharToNumber + 33));
                }
                Console.WriteLine();
            }
        }
    }
}
