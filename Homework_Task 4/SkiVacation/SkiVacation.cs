using System;
class SkiVacation
{
    static void Main()
    {
        int days = int.Parse(Console.ReadLine()) - 1;
        string sortHotel = Console.ReadLine();
        string grade = Console.ReadLine();
        double bill = 0.00;
        double roomForOnePerson = 18.00;
        double apartment = 25.00;
        double presidentApartment = 35.00;
        if (sortHotel == "room for one person")
        {
            bill = days * roomForOnePerson;
            if (grade == "positive")
            {
                bill = bill + bill * 0.25;
            }
            else if (grade == "negative")
            {
                bill = bill - bill * 0.10;
            }
        }
        else if (sortHotel == "apartment")
        {
            if (days < 10)
            {
                bill = days * apartment;
                bill = bill - bill * 0.30;
                if (grade == "positive")
                {
                    bill = bill + bill * 0.25;
                }
                else if (grade == "negative")
                {
                    bill = bill - bill * 0.10;
                }
            }
            else if (days >= 10 && days < 15)
            {
                bill = days * apartment;
                bill = bill - bill * 0.35;
                if (grade == "positive")
                {
                    bill = bill + bill * 0.25;
                }
                else if (grade == "negative")
                {
                    bill = bill - bill * 0.10;
                }
            }
            else if (days > 15)
            {
                bill = days * apartment;
                bill = bill - bill * 0.50;
                if (grade == "positive")
                {
                    bill = bill + bill * 0.25;
                }
                else if (grade == "negative")
                {
                    bill = bill - bill * 0.10;
                }
            }
        }
        else if (sortHotel == "president apartment")
        {
            if (days < 10)
            {
                bill = days * presidentApartment;
                bill = bill - bill * 0.10;
                if (grade == "positive")
                {
                    bill = bill + bill * 0.25;
                }
                else if (grade == "negative")
                {
                    bill = bill - bill * 0.10;
                }
            }
            else if (days >= 10 && days < 15)
            {
                bill = days * presidentApartment;
                bill = bill - bill * 0.15;
                if (grade == "positive")
                {
                    bill = bill + bill * 0.25;
                }
                else if (grade == "negative")
                {
                    bill = bill - bill * 0.10;
                }
            }
            else if (days > 15)
            {
                bill = days * presidentApartment;
                bill = bill - bill * 0.20;
                if (grade == "positive")
                {
                    bill = bill + bill * 0.25;
                }
                else if (grade == "negative")
                {
                    bill = bill - bill * 0.10;
                }
            }
        }
        Console.WriteLine("{0:F2}", bill);
    }
}
