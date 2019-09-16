using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSumLeftRightPossition
{
    class LeftRight
    {
        static void Main(string[] args)
        {
            int firstNum = int.Parse(Console.ReadLine());
            int secondtNum = int.Parse(Console.ReadLine());

            for (int i = firstNum; i <= secondtNum; i++)
            {
                string number = i.ToString();
                int char5 = int.Parse(number[0].ToString());
                int char4 = int.Parse(number[1].ToString());
                int char3 = int.Parse(number[2].ToString());
                int char2 = int.Parse(number[3].ToString());
                int char1 = int.Parse(number[4].ToString());

                int leftSum = char5 + char4;
                int rightSum = char2 + char1;
                int middleSum = char3;

                if (leftSum == rightSum)
                {
                    Console.Write(number + " ");
                }
                else if (leftSum > rightSum)
                {
                    rightSum += middleSum;
                    if (leftSum == rightSum)
                    {
                        Console.Write(number + " ");
                    }
                }
                else if (leftSum < rightSum)
                {
                    leftSum += middleSum;
                    if (leftSum == rightSum)
                    {
                        Console.Write(number + " ");
                    }
                }
            }
        }
    }
}
