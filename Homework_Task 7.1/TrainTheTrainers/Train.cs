using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrainTheTrainers
{
    class Train
    {
        static void Main(string[] args)
        {
            int juryCount = int.Parse(Console.ReadLine());
            string presentation = string.Empty;
            double sumGrade = 0;
            double averageGrade = 0.0;
            double totalSumGrade = 0;
            double totalAverageGrade = 0;
            double gradeCount = 0;
            
            while (presentation != "Finish")
            {
                presentation = Console.ReadLine();
                if (presentation == "Finish")
                {
                    totalAverageGrade = totalSumGrade / gradeCount;
                    Console.WriteLine($"Student's final assessment is {totalAverageGrade:f2}.");
                    break;
                }
                for (int i = 1; i <= juryCount; i++)
                {
                    double grade = double.Parse(Console.ReadLine());
                    sumGrade += grade;
                    averageGrade = sumGrade / juryCount;
                    gradeCount++;
                    totalSumGrade += grade;
                }
                Console.WriteLine($"{presentation} - {averageGrade:f2}.");
                sumGrade = 0;
                averageGrade = 0;
            }
        }
    }
}
