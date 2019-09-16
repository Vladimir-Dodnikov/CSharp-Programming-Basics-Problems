using System;

    class SwimWR
    {
        static void Main()
        {
        double WRSeconds = double.Parse(Console.ReadLine());
        double distanceInMeters = double.Parse(Console.ReadLine());
        double time1mInSeconds = double.Parse(Console.ReadLine());

        double swimSeries = distanceInMeters * time1mInSeconds;
        double delaySeconds = Math.Floor(distanceInMeters / 15) * 12.5;
        double totalSwimTime = swimSeries + delaySeconds;
        double time = totalSwimTime - WRSeconds;
        if (totalSwimTime >= WRSeconds)
        {
            Console.WriteLine("No, he failed! He was {0:F2} seconds slower.", Math.Abs(time));
        }
        else if (totalSwimTime < WRSeconds)
        {
            Console.WriteLine("Yes, he succeeded! The new world record is {0:F2} seconds.", totalSwimTime);
        }
        }
    }
