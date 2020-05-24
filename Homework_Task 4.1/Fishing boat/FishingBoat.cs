using System;

    class FishingBoat
    {
        static void Main()
        {
        double groupBudget = double.Parse(Console.ReadLine());
        string season = Console.ReadLine();
        double countFishers = double.Parse(Console.ReadLine());

        double currentPrice = 0.0;
        double finalPrice = 0.0;

        if (season == "Spring")
        {
            if (countFishers <= 6)
            {
                currentPrice = 3000 - 3000 * 0.10;
            }
            else if (countFishers > 6 && countFishers <= 11)
            {
                currentPrice = 3000 - 3000 * 0.15;
            }
            else if (countFishers >= 12)
            {
                currentPrice = 3000 - 3000 * 0.25;
            }
        }
        else if (season == "Summer" || season == "Autumn")
        {
            if (countFishers <= 6)
            {
                currentPrice = 4200 - 4200 * 0.10;
            }
            else if (countFishers > 6 && countFishers <= 11)
            {
                currentPrice = 4200 - 4200 * 0.15;
            }
            else if (countFishers >= 12)
            {
                currentPrice = 4200 - 4200 * 0.25;
            }
        }
        else if (season == "Winter")
        {
            if (countFishers <= 6)
            {
                currentPrice = 2600 - 2600 * 0.10;
            }
            else if (countFishers > 6 && countFishers <= 11)
            {
                currentPrice = 2600 - 2600 * 0.15;
            }
            else if (countFishers >= 12)
            {
                currentPrice = 2600 - 2600 * 0.25;
            }
        }
        if (countFishers % 2 == 0 && season != "Autumn")
        {
            finalPrice = currentPrice - currentPrice * 0.05;
        }
        else
        {
            finalPrice = currentPrice;
        }
        if (finalPrice <= groupBudget)
        {
            Console.WriteLine($"Yes! You have {(groupBudget-finalPrice):f2} leva left.");
        }
        else
        {
            Console.WriteLine($"Not enough money! You need {(finalPrice-groupBudget):f2} leva.");
        }
        }
    }
