using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Time15
{
    class Time15
    {
        static void Main(string[] args)
        {
            int startHour = int.Parse(Console.ReadLine());
            int startMinute = int.Parse(Console.ReadLine());
            int sumMinutes = startHour * 60 + startMinute;
            int plus15Minutes = sumMinutes + 15;

            int finalHour = plus15Minutes / 60;
            int finalMinutes = plus15Minutes % 60;
            if (finalHour >= 24)
            {
                finalHour -= 24;
            }
            if (finalMinutes < 10)
            {
                Console.WriteLine("{0}:0{1}", finalHour, finalMinutes);
            }
            else
            {
                Console.WriteLine("{0}:{1}", finalHour, finalMinutes);
            }
        }
    }
}
