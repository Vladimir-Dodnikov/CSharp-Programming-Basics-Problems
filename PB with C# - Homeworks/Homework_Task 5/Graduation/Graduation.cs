using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double clas = 1;
            double sum = 0;

            while (clas <= 12)
            {

                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum += grade;
                    clas++;
                }
            }

            double average = sum / 12.0;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Graduation
{
    class Graduation
    {
        static void Main(string[] args)
        {
            string name = Console.ReadLine();
            double clas = 1;
            double sum = 0;

            while (clas <= 12)
            {

                double grade = double.Parse(Console.ReadLine());
                if (grade >= 4.00)
                {
                    sum += grade;
                    clas++;
                }
            }

            double average = sum / 12.0;
            Console.WriteLine($"{name} graduated. Average grade: {average:f2}");
        }
    }
}
