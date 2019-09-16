using System;
class OldLibrary
{
    static void Main()
    {
        string bookName = Console.ReadLine();
        int Library = int.Parse(Console.ReadLine());
        int count = 0;
        bool bookFound = false;

        while (count < Library)
        {
            string book = Console.ReadLine();
            if (book == bookName)
            {
                bookFound = true;
                break;
            }
            count++;
        }
        if (bookFound)
            Console.WriteLine($"You checked {count} books and found it.");
        else
        {
            Console.WriteLine("The book you search is not here!");
            Console.WriteLine($"You checked {count} books.");
        }
    }
}
