using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation2
{
    class Graduation2
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double clas = 1;
            double sum = 0;
            double excluded = 0.0;
            bool isExcluded = false;

            while (clas <= 12)
            {

                double grade = double.Parse(Console.ReadLine());
                if (grade < 4.00)
                {
                    excluded++;
                }
                else if (grade >= 4.00)
                {
                    sum += grade;
                    clas++;
                }
                if (excluded >= 2)
                {
                    isExcluded = true;
                    break;
                }
            }
            if (isExcluded == false)
            {
                double average = sum / 12.0;
                Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
            }
            else
            {
                Console.WriteLine($"{name} has been excluded at {clas} grade");
            }
            
        }
    }
}
