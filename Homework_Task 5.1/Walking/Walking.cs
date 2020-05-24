using System;
class Walking
{
    static void Main()
    {
        int purpose = 10000;
        int stepsSum = 0;
        string outPut = string.Empty;

        while (true)
        {
            string command = Console.ReadLine();

            if (command == "Going home")
            {
                int finalSteps = int.Parse(Console.ReadLine());
                stepsSum += finalSteps;
                break;
            }
            else
            {
                int currentSteps = int.Parse(command);
                stepsSum += currentSteps;

                if (stepsSum >= purpose)
                    break;
            }
        }
        if (stepsSum >= purpose)
        {
            outPut = "Goal reached! Good job!";
        }
        else
        {
            outPut = $"{purpose - stepsSum} more steps to reach goal.";
        }
        Console.WriteLine(outPut);
    }
}
