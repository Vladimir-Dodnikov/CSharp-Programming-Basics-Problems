using System;

    class ThreeBrothers
    {
        static void Main()
        {
        double firstBrother = double.Parse(Console.ReadLine());
        double secondBrother = double.Parse(Console.ReadLine());
        double thirdBrother = double.Parse(Console.ReadLine());
        double fatherTime = double.Parse(Console.ReadLine());

        double sumClean = 1 / (1/firstBrother + 1/secondBrother + 1/thirdBrother);
        double totalClean = sumClean * 1.15;
        double leftTime = fatherTime - totalClean;
        Console.WriteLine("Cleaning time: {0:F2}", totalClean);

        if (leftTime >= 0)
        {
            Console.WriteLine("Yes, there is a surprise - time left -> {0:F0} hours.", Math.Floor(leftTime));
        }
        else
        {
            Console.WriteLine("No, there isn't a surprise - shortage of time -> {0:F0} hours.", Math.Ceiling(Math.Abs(leftTime)));
        }

    }
    }
