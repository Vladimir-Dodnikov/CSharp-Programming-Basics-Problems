using System;

    class Program
    {
        static void Main()
        {
        double income = double.Parse(Console.ReadLine());
        double averageGrade = double.Parse(Console.ReadLine());
        double minSalary = double.Parse(Console.ReadLine());

        double normal = 0.0; 
        double social = 0.0;
        bool yesScolarship = false;

        if (averageGrade > 4.5 && income < minSalary) // проверяваме дали има право за социална стипендия
        {
            social = minSalary * 0.35;
            yesScolarship = true;
        }

        if (averageGrade >= 5.5) // // проверяваме дали има право за стипендия по успех
        {
            normal = averageGrade * 25;
            yesScolarship = true;
        }

        if (yesScolarship == false)
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
        else if (normal >= social) // сравняваме сумите
        {
            Console.WriteLine($"You get a scholarship for excellent results {Math.Floor(normal)} BGN");
        }
        else
        {
            Console.WriteLine($"You get a Social scholarship {Math.Floor(social)} BGN");
        }
    }
    }
