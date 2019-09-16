using System;
    class Aquarium
    {
        static void Main()
        {
            double AquaLenght = double.Parse(Console.ReadLine());
            double AquaWidth = double.Parse(Console.ReadLine());
            double AquaHeight = double.Parse(Console.ReadLine());
            double Percent = double.Parse(Console.ReadLine());

            double AquaVolume = AquaLenght * AquaWidth * AquaHeight;
            double AquaLitres = AquaVolume * 0.001;
            double AquaPercent = Percent * 0.01;
            double Litres = AquaLitres * (1 - AquaPercent);
            Console.WriteLine("{0:F3}", Litres);

        }
    }
