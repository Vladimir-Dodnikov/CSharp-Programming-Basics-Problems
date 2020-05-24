using System;
    class Salary
    {
        static void Main()
        {
        int tabsCount = int.Parse(Console.ReadLine());
        int salary = int.Parse(Console.ReadLine());

        for (int i = 0; i < tabsCount; i++)
        {
            string siteName = Console.ReadLine();
            if (siteName == "Facebook")
            {
                salary -= 150;
            }
            else if (siteName == "Instagram")
            {
                salary -= 100;
            }
            else if (siteName == "Reddit")
            {
                salary -= 50;
            }
            if (salary == 0)
            {
                Console.WriteLine("You have lost your salary.");
                break;          //return; - spira programata
            }
        }
        if (salary > 0)         // togava otpada if-a
        {
            Console.WriteLine(salary);
        }
        }
    }
