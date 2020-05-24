using System;

class SmartLilly
{
    static void Main()
    {
        int age = int.Parse(Console.ReadLine());
        double washingMachinePrice = double.Parse(Console.ReadLine());
        int singleToyPrice = int.Parse(Console.ReadLine());

        int toysCounter = 0;
        int moneyGift = 10;
        int totalMoneyIncomes = 0;

        for (int i = 1; i <= age; i++)
        {
            if (i % 2 == 0)
            {
                totalMoneyIncomes += moneyGift;
                totalMoneyIncomes -= 1;
                moneyGift += 10;
            }
            else
            {
                toysCounter++;
            }
        }
        int soldToysIncome = singleToyPrice * toysCounter;
        int total = totalMoneyIncomes + soldToysIncome;

        double diff = Math.Abs(total - washingMachinePrice);
        if (total >= washingMachinePrice)
        {
            Console.WriteLine($"Yes! {diff:f2}");
        }
        else
        {
            Console.WriteLine($"No! {diff:f2}");
        }
    }
}
