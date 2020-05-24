using System;
class Journey
{
    static void Main()
    {
        string yearType = Console.ReadLine();
        int holidaysCount = int.Parse(Console.ReadLine());
        int weekendsHomeTrips = int.Parse(Console.ReadLine());

        int weekendsPerYear = 48;
        double gamesInWeekendsInSofia = (weekendsPerYear - weekendsHomeTrips) * 0.75;
        double gamesInWeekendsInHomeTown = weekendsHomeTrips;

        double gamesInHolidays = holidaysCount * (2.0 / 3);
        double totalGamesCount = gamesInHolidays + gamesInWeekendsInHomeTown + gamesInWeekendsInSofia;

        if (yearType == "leap")
        {
            totalGamesCount *= 1.15;
        }
        else if (yearType == "normal")
        {
            totalGamesCount *= 1.00;
        }
        Console.WriteLine(Math.Floor(totalGamesCount));
    }
}
