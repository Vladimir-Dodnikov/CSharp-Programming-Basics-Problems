using System;
class PersonalTitles
{
    static void Main()
    {
        double age = double.Parse(Console.ReadLine());
        string gender = Console.ReadLine();
        if (gender == "f")
        {
            if (age < 16)
            {
                Console.WriteLine("Miss");
            }  
            else if (age >= 16)
            {
                Console.WriteLine("Ms.");
            }
        }
        else if (gender == "m")
        {
            if (age < 16)
            {
                Console.WriteLine("Master");
            }
            else if (age >= 16)
            {
                Console.WriteLine("Mr.");
            }
        }
    }
}
