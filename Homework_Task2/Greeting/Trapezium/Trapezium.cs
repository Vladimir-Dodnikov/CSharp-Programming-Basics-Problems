using System;
    class Trapezium
    {
        static void Main()
        {
            double b1 = double.Parse(Console.ReadLine());
            double b2 = double.Parse(Console.ReadLine());
            double h = double.Parse(Console.ReadLine());
            double Area = (b1 + b2) / 2 * h;
                Console.WriteLine("{0:F2}", Area);
        }
    }
