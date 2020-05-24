using System;

class OddEvenP
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double oddSum = 0.0;
        double oddMin = double.MaxValue;
        double oddMax = double.MinValue;

        double evenSum = 0.0;
        double evenMin = double.MaxValue;
        double evenMax = double.MinValue;

        for (int i = 1; i <= n; i++)
        {
            double current = double.Parse(Console.ReadLine());
            if (i % 2 == 0)
            {
                evenSum += current;
                if (current > evenMax)
                {
                    evenMax = current;
                }
                if (current < evenMin)
                {
                    evenMin = current;
                }
            }
            else
            {
                oddSum += current;
                if (current > oddMax)
                {
                    oddMax = current;
                }
                if (current < oddMin)
                {
                    oddMin = current;
                }
            }
        }

        Console.WriteLine($"OddSum={oddSum:f2},");

        if (oddMin != double.MaxValue)
        {
            Console.WriteLine($"OddMin={oddMin:F2},");
        }
        else
        {
            Console.WriteLine($"OddMin=No,");
        }

        if (oddMax != double.MinValue)
        {
            Console.WriteLine($"OddMax={oddMax:F2},");
        }
        else
        {
            Console.WriteLine($"OddMax=No,");
        }

        Console.WriteLine($"EvenSum={evenSum:f2},");

        if (evenMin != double.MaxValue)
        {
            Console.WriteLine($"EvenMin={evenMin:f2},");
        }
        else
        {
            Console.WriteLine($"EvenMin=No,");
        }

        if (evenMax != double.MinValue)
        {
            Console.WriteLine($"EvenMax={evenMax:f2}");
        }
        else
        {
            Console.WriteLine($"EvenMax=No");
        }
    }
}
