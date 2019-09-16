using System;

class AreaOfFugures
{
    static void Main()
        {
            string figureShape = Console.ReadLine();
            if (figureShape == "square")
            {
                double side = double.Parse(Console.ReadLine());
                double squareArea = side * side;
                Console.WriteLine("{0:F3}", squareArea);
            }
            else if (figureShape == "rectangle")
            {
                double firstSide = double.Parse(Console.ReadLine());
                double secondSide = double.Parse(Console.ReadLine());
                double rectangleArea = firstSide * secondSide;
                Console.WriteLine("{0:F3}", rectangleArea);
            }
            else if (figureShape == "circle")
            {
                double radius = double.Parse(Console.ReadLine());
                double circleArea = Math.PI * radius * radius;
                Console.WriteLine("{0:F3}", circleArea);
            }
                else if (figureShape == "triangle")
            {
                double Side = double.Parse(Console.ReadLine());
                double heightSide = double.Parse(Console.ReadLine());
                double triangleArea = Side * heightSide / 2;
                Console.WriteLine("{0:F3}", triangleArea);
            }
       }
}
