using System;

class NumSequence
{
    static void Main()
    {
        int smallestNum = int.MaxValue;
        int biggestNum = int.MinValue;
        int count = int.Parse(Console.ReadLine());

        for (int num = 1; num <= count; num++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current > biggestNum)
            {
                biggestNum = current;
            }
            if (current < smallestNum)
            {
                smallestNum = current;
            }
        }
        Console.WriteLine($"Max number: {biggestNum}");
        Console.WriteLine($"Min number: {smallestNum}");
    }
}