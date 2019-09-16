using System;
    class SimpleOperations
    {
        static void Main()
        {
            Console.WriteLine("Hello World");   //string
            
            string Name = "Hello World";    //standart string
            Console.WriteLine(Name);        //print string

            char Letter = 'a';      //char type
            Console.WriteLine(Letter);  //print char type

            bool Statement = true;  //moje da bude samo true ili false

            int Min = int.MinValue;
            Console.WriteLine(Min);

            double Max = double.MaxValue;
            Console.WriteLine(Max);

            int NameValue = int.Parse(Console.ReadLine());
            int N = int.Parse("5"); //string stava number   ///////////////!!!!!

            double Area = double.Parse(Console.ReadLine());
            double AreaTwo = Area * Area;
            Console.WriteLine("{0:F2}", AreaTwo);   //zacruglq do vtoria znak

        }
    }
