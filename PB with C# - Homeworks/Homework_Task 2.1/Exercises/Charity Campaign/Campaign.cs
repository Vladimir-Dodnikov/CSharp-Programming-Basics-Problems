using System;

    class Campaign
    {
        static void Main()
        {
            int DaysCampaign = int.Parse(Console.ReadLine());
            int Bakers = int.Parse(Console.ReadLine());
            int Cakes = int.Parse(Console.ReadLine());
            int Waffles = int.Parse(Console.ReadLine());
            int Pancakes = int.Parse(Console.ReadLine());
            double CakesSum = Cakes * 45;
            double WafflesSum = Waffles * 5.80;
            double PancakesSum = Pancakes * 3.20;
            double Bakery = Bakers * (CakesSum + WafflesSum + PancakesSum);
            double CampaignSum = Bakery * DaysCampaign;
            double SumAfterCosts = CampaignSum - (CampaignSum/8);
            Console.WriteLine("{0:F2}", SumAfterCosts);
        }
    }
