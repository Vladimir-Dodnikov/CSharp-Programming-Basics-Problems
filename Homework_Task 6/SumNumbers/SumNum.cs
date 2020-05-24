using System;

    class SumNum
    {
        static void Main()
        {
        int num = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = 1; i <= num; i++)
        {
            int current = int.Parse(Console.ReadLine());
            sum += current;
        }
        Console.WriteLine(sum);
        }
    }
