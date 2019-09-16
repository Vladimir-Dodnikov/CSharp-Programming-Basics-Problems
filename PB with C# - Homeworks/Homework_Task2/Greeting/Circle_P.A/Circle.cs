using System;

    class Circle
    {
        static void Main()
        {
            double r = double.Parse(Console.ReadLine());
            double Perimeter = 2 * Math.PI * r;
            double Area = Math.PI * r * r;
            Console.WriteLine("{0:F2}", Area);
            Console.WriteLine("{0:F2}", Perimeter);
        }
    }
