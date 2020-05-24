using System;
class Program
{
    static void Main()
    {
        int degrees = int.Parse(Console.ReadLine());
        string dayTime = Console.ReadLine();
        string Outfit = string.Empty;
        string Shoes = string.Empty;
        if (dayTime == "Morning")
        {
            if (degrees >=10 && degrees <= 18)
            {
                Outfit = "Sweatshirt";
                Shoes = "Sneakers";
            }
            else if (degrees >= 18 && degrees <= 24)
            {
                Outfit = "Shirt";
                Shoes = "Moccasins"; ;
            }
            else if (degrees >25)
            {
                Outfit = "T-Shirt";
                Shoes = "Sandals";
            }
        }
        else if (dayTime == "Afternoon")
        {
            if (degrees >= 10 && degrees <= 18)
            {
                Outfit = "Shirt";
                Shoes = "Moccasins";
            }
            else if (degrees >= 18 && degrees <= 24)
            {
                Outfit = "T-Shirt";
                Shoes = "Sandals";
            }
            else if (degrees >= 25)
            {
                Outfit = "Swim Suit";
                Shoes = "Barefoot";
            }
        }
        else if (dayTime == "Evening")
        {
            if (degrees >= 10 && degrees <= 18)
            {
                Outfit = "Shirt";
                Shoes = "Moccasins";
            }
            else if (degrees >= 18 && degrees <= 24)
            {
                Outfit = "Shirt";
                Shoes = "Moccasins";
            }
            else if (degrees >= 25)
            {
                Outfit = "Shirt";
                Shoes = "Moccasins";
            }
        }
        Console.WriteLine("It's {0} degrees, get your {1} and {2}.", degrees, Outfit, Shoes);
    }
}
