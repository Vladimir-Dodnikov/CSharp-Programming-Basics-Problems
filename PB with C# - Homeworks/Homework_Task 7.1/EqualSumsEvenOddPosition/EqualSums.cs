using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumsEvenOddPosition
{
    class EqualSums
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondNum; i++)
            {
                string currentNum = i.ToString();
                int oddSum = 0;
                int evenSum = 0;
                for (int j = 0; j < currentNum.Length; j++)
                {
                    int currentChar = int.Parse(currentNum[j].ToString());
                    if (j % 2 == 0)
                    {
                        oddSum += currentChar;
                    }
                    else
                    {
                        evenSum += currentChar;
                    }
                }
                if (oddSum == evenSum)
                {
                    Console.Write(i + " ");
                }
            }

        }
    }
}
