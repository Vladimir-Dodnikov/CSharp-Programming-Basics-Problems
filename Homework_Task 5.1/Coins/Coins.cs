using System;
class Coins
{
    static void Main()
    {
       decimal change = decimal.Parse(Console.ReadLine());
        int count = 0;
        while (change > 0)
        {
            if (change >= 2)
            {
                change -= 2;
            }
            else if (change >= 1)
            {
                change -= 1;
            }
            else if (change >= (decimal)0.5)
            {
                change -= (decimal)0.5;
            }
            else if (change >= (decimal)0.2)
            {
                change -= (decimal)0.2;
            }
            else if (change >= (decimal)0.1)
            {
                change -= (decimal)0.1;
            }
            else if (change >= (decimal)0.05)
            {
                change -= (decimal)0.05;
            }
            else if (change >= (decimal)0.02)
            {
                change -= (decimal)0.02;
            }
            else if (change >= (decimal)0.01)
            {
                change -= (decimal)0.01;
            }
            count++;
        }
        Console.WriteLine(count);
    }
}
