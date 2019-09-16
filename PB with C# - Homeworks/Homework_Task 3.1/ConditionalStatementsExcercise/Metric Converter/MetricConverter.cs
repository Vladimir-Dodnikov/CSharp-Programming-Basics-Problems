using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metric_Converter
{
    class MetricConverter
    {
        static void Main(string[] args)
        {
            double value = double.Parse(Console.ReadLine());
            string inputMetric = Console.ReadLine();
            string outputMetric = Console.ReadLine();

            if (inputMetric == "mm")
            {
                value /= 1000;
            }
            else if (inputMetric == "cm")
            {
                value /= 100;
            }
            if (outputMetric == "mm")
            {
                value *= 1000;
            }
            else if (outputMetric == "cm")
            {
                value *= 100;
            }
            Console.WriteLine("{0:f3}", value);
        }
    }
}
