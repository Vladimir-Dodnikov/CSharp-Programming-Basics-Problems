using System;
class ExPreparation
{
    static void Main()
    {
        int badGrades = int.Parse(Console.ReadLine());
        int countBadGrades = 0;
        int totalCountGrades = 0;
        int sumGrades = 0;
        string lastTask = string.Empty;     //or ="";

        while (countBadGrades < badGrades)
        {
            string taskName = Console.ReadLine();
            if (taskName == "Enough")
            {
                break;
            }
            int currentGrade = int.Parse(Console.ReadLine());

            lastTask = taskName;
            totalCountGrades++;
            sumGrades += currentGrade;
            if (currentGrade <= 4)
            {
                countBadGrades++;
            }
        }
        if (badGrades == countBadGrades)
        {
            Console.WriteLine($"You need a break, {countBadGrades} poor grades.");
        }
        else
        {
            double averageGrade = sumGrades / (double)totalCountGrades; //cast-vane
            Console.WriteLine($"Average score: {averageGrade:f2}");
            Console.WriteLine($"Number of problems: {totalCountGrades}");
            Console.WriteLine($"Last problem: {lastTask}");
        }
    }
}
