using System;
    class Convert_Temp
    {
        static void Main()
        {
            double Celsius = double.Parse(Console.ReadLine());
            double Fahrenheit = (Celsius * 9) / 5 + 32;
            Console.WriteLine("{0:F2}", Fahrenheit);
        }
    }
