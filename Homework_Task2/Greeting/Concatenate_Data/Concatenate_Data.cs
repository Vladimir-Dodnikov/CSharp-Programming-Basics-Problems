using System;

    class Concatenate_Data
    {
        static void Main()
        {
            string FirstName = Console.ReadLine();
            string LastName = Console.ReadLine();
            int Age = int.Parse(Console.ReadLine());
            string Town = Console.ReadLine();

            Console.WriteLine("You are {0} {1}, a {2}-years old person from {3}.", 
                FirstName, LastName, Age, Town);
        }
    }
