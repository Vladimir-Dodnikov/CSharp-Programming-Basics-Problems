using System;

class Scholarship
{
    static void Main()
    {
        double income = double.Parse(Console.ReadLine());
        double averageGrade = double.Parse(Console.ReadLine());
        double minSalary = double.Parse(Console.ReadLine());
        double social = minSalary * 0.35;
        social = Math.Floor(social);
        double normal = averageGrade * 25;
        normal = Math.Floor(normal);

        if (income > minSalary && averageGrade < 5.50)
        {
            Console.WriteLine("You cannot get a scholarship!");
        }
        else if (income <= minSalary && averageGrade >= 4.50 && averageGrade < 5.50)
        {
            Console.WriteLine("You get a Social scholarship {0} BGN", social);
        }
        else if (income <= minSalary && averageGrade >= 5.50)
        {
            Console.WriteLine("You get a scholarship for excellent results {0} BGN", normal);
        }
        else if (social > normal)
        {
            Console.WriteLine("You get a Social scholarship {0} BGN", social);
        }
        else if (social <= normal)
        {
            Console.WriteLine("You get a scholarship for excellent results {0} BGN", normal);
        }
    }
}
