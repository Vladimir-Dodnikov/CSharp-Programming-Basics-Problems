using System;

    class Program
    {
        static void Main()
        {
        int hourExam = int.Parse(Console.ReadLine());
        int minuteExam = int.Parse(Console.ReadLine());
        int hourArrival = int.Parse(Console.ReadLine());
        int minuteArrival = int.Parse(Console.ReadLine());

        double timeExam = hourExam * 60 + minuteExam;
        double timeArrival = hourArrival * 60 + minuteArrival;
        double timeLate = 0.0;
        double hoursLate = 0.0;
        double minutesLate = 0.0;
        double onTime = 0.0;
        double timeEarly = 0.0;
        double hoursEarly = 0.0;
        double minutesEarly = 0.0;

        if (timeArrival > timeExam)
        {
            timeLate = timeArrival - timeExam;
            if (timeLate < 60)
            {
                Console.WriteLine("Late");
                Console.WriteLine("{0} minutes after the start", timeLate);
            }
            else if (timeLate >= 60)
            {
                hoursLate = Math.Floor(timeLate / 60);
                minutesLate = Math.Abs(timeLate % 60);
                Console.WriteLine("Late");
                Console.WriteLine("{0:f0}:{1:00} hours after the start", hoursLate, minutesLate);
            }
        }
        else if ((timeArrival + 30 >= timeExam) && (timeArrival <= (timeExam + 30)))
        {
            onTime = timeExam - timeArrival;
            Console.WriteLine("On time");
            Console.WriteLine("{0:f0} minutes before the start", onTime);
        }
        else if (timeArrival < timeExam)
        {
            timeEarly = timeExam - timeArrival;
            if (timeEarly < 60)
            {
                Console.WriteLine("Early");
                Console.WriteLine("{0:f0} minutes before the start", timeEarly);
            }
            else if (timeEarly >= 60)
            {
                hoursEarly = Math.Floor(timeEarly / 60);
                minutesEarly = Math.Abs(timeEarly % 60);
                Console.WriteLine("Early");
                Console.WriteLine("{0:f0} {1:00} hours before the start", hoursEarly, minutesEarly);
            }
        }
    }
    }
