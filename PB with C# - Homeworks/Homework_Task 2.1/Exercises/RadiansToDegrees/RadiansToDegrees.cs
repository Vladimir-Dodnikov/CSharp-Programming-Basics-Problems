using System;

    class RadiansToDegrees
    {
        static void Main()
        {
            double Rad = double.Parse(Console.ReadLine());
            double RadToDeg = 180 / Math.PI;
            double Deg = Rad * RadToDeg;
            Console.WriteLine(Math.Round(Deg));
        }
    }
