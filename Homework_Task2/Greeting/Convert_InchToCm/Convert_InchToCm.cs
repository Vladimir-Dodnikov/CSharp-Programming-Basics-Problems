using System;
    class Convert_InchToCm
    {
        static void Main()
        {
            double Inch = double.Parse(Console.ReadLine());
            double Cm = Inch * 2.54;
            Console.WriteLine("{0:F2}", Cm);
        }
    }
