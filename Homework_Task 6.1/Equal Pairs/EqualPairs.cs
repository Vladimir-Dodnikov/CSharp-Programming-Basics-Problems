using System;

class EqualPairs
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int lastSum = 0;
        int maxDiff = int.MinValue;

        for (int i = 0; i < n; i++)
        {
            int currentDiff = 0;

            int firstNum = int.Parse(Console.ReadLine());
            int secondNum = int.Parse(Console.ReadLine());
            int sum = firstNum + secondNum;

            if (i == 0)
            {
                lastSum = sum;
            }

            if (lastSum != sum)
            {
                currentDiff = Math.Abs(lastSum - sum);
            
                if (currentDiff > maxDiff)
                {
                    maxDiff = currentDiff;
                }
            }
            lastSum = sum;
        }

        if (maxDiff != int.MinValue)
        {
            Console.WriteLine("No, maxdiff={0}", maxDiff);
        }
        else
        {
            Console.WriteLine("Yes, value={0}", lastSum);
        }
        
    }
}
