using System;

class Choreography
{
    static void Main()
    {
        double steps = double.Parse(Console.ReadLine());
        double dancers = double.Parse(Console.ReadLine());
        double days = double.Parse(Console.ReadLine());

        double dailySteps = ((steps / days) / steps) * 100;
        dailySteps = Math.Ceiling(dailySteps);
        double stepsPerDancer = dailySteps / dancers;

        if (dailySteps <= 13)
        {
            Console.WriteLine($"Yes, they will succeed in that goal! {stepsPerDancer:F2}%.");
        }
        else if (dailySteps > 13)
        {
            Console.WriteLine($"No, They will not succeed in that goal! Required {stepsPerDancer:F2}% steps to be learned per day.");
        }
    }
}

