using System;

    class ToyStore
    {
        static void Main()
        {
            double priceHolliday = double.Parse(Console.ReadLine());
            int pizzleCount = int.Parse(Console.ReadLine());
            int dollsCount = int.Parse(Console.ReadLine());
            int bearsCount = int.Parse(Console.ReadLine());
            int minionsCount = int.Parse(Console.ReadLine());
            int trucksCount = int.Parse(Console.ReadLine());
            double pizzlePrice = 2.60;
            double dollsPrice = 3.00;
            double bearsPrice = 4.10;
            double minionsPrice = 8.20;
            double trucksPrice = 2.00;

            double sum =
                pizzleCount * pizzlePrice + dollsCount * dollsPrice + bearsCount * bearsPrice + minionsCount * minionsPrice + trucksCount * trucksPrice;
            int toyCount = pizzleCount + dollsCount + bearsCount + minionsCount + trucksCount;
            if (toyCount >= 50)
            {
                double discount = sum * 0.25;
                sum = sum - discount;    
            }
            double rent = sum * 0.1;
            sum -= rent;
            if (sum >= priceHolliday)
            {
                Console.WriteLine("Yes! {0:F2} lv left.", sum - priceHolliday);
            }
            else
            {
                Console.WriteLine("Not enough money! {0:F2} lv needed.", Math.Abs(sum - priceHolliday));
            }
        }
    }
