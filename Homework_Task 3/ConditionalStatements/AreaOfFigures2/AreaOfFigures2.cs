using System;

    class AreaOfFigures2
    {
        static void Main()
        {
            string figureType = Console.ReadLine();
            double figureArea = 0.0;
            switch (figureType)
            {
                case "square":
                    {
                        double a = double.Parse(Console.ReadLine());
                        figureArea = a * a;
                        break;
                    }
                case "rectangle":
                    {
                        double sideA = double.Parse(Console.ReadLine());
                        double sideB = double.Parse(Console.ReadLine());
                        figureArea = sideA * sideB;
                        break;
                    }
                case "circle":
                    {
                        double radius = double.Parse(Console.ReadLine());
                        figureArea = Math.PI * radius * radius;
                        break;
                    }
                case "triangle":
                    {
                        double side1 = double.Parse(Console.ReadLine());
                        double height = double.Parse(Console.ReadLine());
                        figureArea = side1 * height / 2;
                        break;
                    }
             }
            Console.WriteLine("{0:F3}", figureArea);              
        }
    }
