using System;

    class RectangleArea
    {
        static void Main()
        {
            double x1 = double.Parse(Console.ReadLine());
            double y1 = double.Parse(Console.ReadLine());
            double x2 = double.Parse(Console.ReadLine());
            double y2 = double.Parse(Console.ReadLine());

            double Length = Math.Abs(x2 - x1);
            double Width = Math.Abs(y2 - y1);

            double Area = Length * Width;
            double Perimeter = 2 * (Length + Width);

            Console.WriteLine("{0:F2}", Area);
            Console.WriteLine("{0:F2}", Perimeter);
        }
    }
