using System;

    class DanceHall
    {
        static void Main()
        {
            double LengthHall = double.Parse(Console.ReadLine());
            double WidthHall = double.Parse(Console.ReadLine());
            double SideWardrobe = double.Parse(Console.ReadLine());
            double AreaHall = (LengthHall * 100) * (WidthHall * 100);
            double AreaWardrobe = (SideWardrobe * 100) * (SideWardrobe * 100);
            double BenchSize = AreaHall / 10;
            double FreeSpace = AreaHall - AreaWardrobe - BenchSize;
            double Dancers = FreeSpace / (40 + 7000);
            Console.WriteLine(Math.Floor(Dancers));
        }
    }
