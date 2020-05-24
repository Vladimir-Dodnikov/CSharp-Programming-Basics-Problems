using System;
    class TriangleArea
    {
        static void Main()
        {
            double Side = double.Parse(Console.ReadLine());
            double Height = double.Parse(Console.ReadLine());
            double area = (Side * Height) / 2;
            Console.WriteLine("{0:F2}", area);
        }
    }
