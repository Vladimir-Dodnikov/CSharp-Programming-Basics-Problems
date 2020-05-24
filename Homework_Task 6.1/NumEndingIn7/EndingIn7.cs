using System;

class EndingIn7
{
    static void Main()
    {
        for (int i = 1; i <= 1000; i++)     //i=7; i<=997; i+=10;
        {
            if (i % 10 == 7)                // otpada
            {
                Console.WriteLine(i);
            }
        }
    }
}
