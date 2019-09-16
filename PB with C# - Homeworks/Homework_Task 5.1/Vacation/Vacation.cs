using System;
class Vacation
{
    static void Main()
    {
        double neededMoney = double.Parse(Console.ReadLine());
        double ownedMoney = double.Parse(Console.ReadLine());
        int daysCount = 0;
        int spendDaysCount = 0;
        while (ownedMoney < neededMoney)
        {
            string command = Console.ReadLine();
            double dailyMoney = double.Parse(Console.ReadLine());

            daysCount++;

            if (command == "spend")
            {
                ownedMoney -= dailyMoney;
                if (ownedMoney < 0)
                {
                    ownedMoney = 0;
                }
                spendDaysCount++;
                if (spendDaysCount >= 5)
                {
                    break;
                }
            }
            else if (command == "save")
            {
                ownedMoney += dailyMoney;
                spendDaysCount = 0;
            }
        }
        if (ownedMoney >= neededMoney)
        {
            Console.WriteLine($"You saved the money for {daysCount} days.") ;
        }
        else if (spendDaysCount >= 5)
        {
            Console.WriteLine("You can't save the money.");
            Console.WriteLine(daysCount);
        }
    }
}
