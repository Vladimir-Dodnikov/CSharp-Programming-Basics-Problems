using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6.Easter_Competition
{
    class EasterCompete
    {
        static void Main(string[] args)
        {
            int easterBreadCount = int.Parse(Console.ReadLine());
            string bakersName = string.Empty;
            string grade = string.Empty;
            string bestName = string.Empty;
            int gradeCount = 0;
            int maxGrade = 0;
            for (int i = 1; i <= easterBreadCount; i++)
            {
                bakersName = Console.ReadLine();
                grade = Console.ReadLine();
                while (grade != "Stop")
                {
                    gradeCount += int.Parse(grade);
                    grade = Console.ReadLine();
                }
                if (grade == "Stop")
                {
                    Console.WriteLine($"{bakersName} has {gradeCount} points.");
                    if (gradeCount > maxGrade)
                    {
                        maxGrade = gradeCount;
                        bestName = bakersName;
                        Console.WriteLine($"{bakersName} is the new number 1!");
                        
                    }
                    gradeCount = 0;
                }
            }
            Console.WriteLine($"{bestName} won competition with {maxGrade} points!");
        }
    }
}
