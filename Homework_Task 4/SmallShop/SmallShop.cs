using System;

class SmallShop
{
    static void Main()
    {
        string product = Console.ReadLine();
        string town = Console.ReadLine();
        double quantity = double.Parse(Console.ReadLine());
        double price = 0.0;

        double coffeeSofia = 0.50;
        double waterSofia = 0.80;
        double beerSofia = 1.20;
        double sweetsSofia = 1.45;
        double peanutsSofia = 1.60;

        double coffeePlovdiv = 0.40;
        double waterPlovdiv = 0.70;
        double beerPlovdiv = 1.15;
        double sweetsPlovdiv = 1.30;
        double peanutsPlovdiv = 1.50;

        double coffeeVarna = 0.45;
        double waterVarna = 0.70;
        double beerVarna = 1.10;
        double sweetsVarna = 1.35;
        double peanutsVarna = 1.55;

        if (town == "Sofia")
        {
            if (product == "coffee")
            {
                price = coffeeSofia * quantity;
            }
            else if (product == "water")
            {
                price = waterSofia * quantity;
            }
            else if (product == "beer")
            {
                price = beerSofia * quantity;
            }
            else if (product == "sweets")
            {
                price = sweetsSofia * quantity;
            }
            else if (product == "peanuts")
            {
                price = peanutsSofia * quantity;
            }
        }
        else if (town == "Plovdiv")
        {
            if (product == "coffee")
            {
                price = coffeePlovdiv * quantity;
            }
            else if (product == "water")
            {
                price = waterPlovdiv * quantity;
            }
            else if (product == "beer")
            {
                price = beerPlovdiv * quantity;
            }
            else if (product == "sweets")
            {
                price = sweetsPlovdiv * quantity;
            }
            else if (product == "peanuts")
            {
                price = peanutsPlovdiv * quantity;
            }
        }
        else if (town == "Varna")
        {
            if (product == "coffee")
            {
                price = coffeeVarna * quantity;
            }
            else if (product == "water")
            {
                price = waterVarna * quantity;
            }
            else if (product == "beer")
            {
                price = beerVarna * quantity;
            }
            else if (product == "sweets")
            {
                price = sweetsVarna * quantity;
            }
            else if (product == "peanuts")
            {
                price = peanutsVarna * quantity;
            }
        }
        Console.WriteLine(price);
    }
}
