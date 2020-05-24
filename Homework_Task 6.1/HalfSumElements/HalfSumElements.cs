using System;
class HalfSumElements
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int maxValue = int.MinValue;
        int sum = 0;

        for (int i = 0; i < n; i++)
        {
            int current = int.Parse(Console.ReadLine());
            if (current > maxValue)
            {
                maxValue = current;
            }
            sum += current;
        }
        sum -= maxValue;
        int diff = Math.Abs(sum - maxValue);
        if (diff == 0)
        {
            Console.WriteLine("Yes");
            Console.WriteLine($"Sum = {sum}");
        }
        else
        {
            Console.WriteLine("No");
            Console.WriteLine($"Diff = {diff}");
        }
    }
}
