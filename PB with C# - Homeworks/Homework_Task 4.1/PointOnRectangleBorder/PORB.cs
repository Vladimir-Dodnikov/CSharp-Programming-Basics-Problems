using System;

namespace PointOnRectangleBorder
{
    class PORB
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());
            double x = double.Parse(Console.ReadLine());
            double y = double.Parse(Console.ReadLine());

            bool fisrtCondition = (x == x1 || x == x2) && (y >= y1 && y <= y2);
            bool secondCondition = (y == y1 || y == y2) && (x >= x1 && x <= x2);

            if (fisrtCondition || secondCondition)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }

        }
    }
}
