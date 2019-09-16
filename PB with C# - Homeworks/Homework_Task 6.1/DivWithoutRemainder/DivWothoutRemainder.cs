using System;
class DivWothoutRemainder
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        double p1Counter = 0;
        double p2Counter = 0;
        double p3Counter = 0;

        for (int i = 0; i < n; i++)
        {
            int num = int.Parse(Console.ReadLine());
            if (num % 2 == 0)
            {
                p1Counter++;
            }
            if (num % 3 == 0)
            {
                p2Counter++;
            }
            if (num % 4 == 0)
            {
                p3Counter++;
            }
        }
        double p1 = p1Counter / n * 100;
        double p2 = p2Counter / n * 100;
        double p3 = p3Counter / n * 100;

        Console.WriteLine($"{p1:f2}%");
        Console.WriteLine($"{p2:f2}%");
        Console.WriteLine($"{p3:f2}%");
    }
}
