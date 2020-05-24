using System;
class CookieFactory
{
    static void Main(string[] args)
    {
        int batchCount = int.Parse(Console.ReadLine());

        bool flour = false;
        bool eggs = false;
        bool sugar = false;

        int bakingBatchCount = 0;

        for (int batch = 0; batch < batchCount; batch++)
        {
            string product = Console.ReadLine();
            while (product != "Bake!")
            {
                if (product == "flour")     //za da se sumirat i trite produkta
                {
                    flour = true;
                }
                if (product == "eggs") //za da se sumirat i trite produkta
                {
                    eggs = true;
                }
                if (product == "sugar") //za da se sumirat i trite produkta
                {
                    sugar = true;
                }
                product = Console.ReadLine();
            }
            if (flour && eggs && sugar)
            {
                bakingBatchCount++;
                Console.WriteLine($"Baking batch number {bakingBatchCount}...");
                flour = false;          //dobaveni sa nakraq za da se nulira bakingBatchCount 
                eggs = false;           // i taka vseki pat da gi broi otnachalo ""0"
                sugar = false;
            }
            else
            {
                batch--;
                Console.WriteLine("The batter should contain flour, eggs and sugar!");
            }
        }
    }
}
