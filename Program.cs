using System;
using System.Threading;



namespace Timer_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Defining work and break periods or durations
            int workDurationMinutes = 25;
            int breakDurationMinutes = 5;

            //Starting timer
            StartingTimer(workDurationMinutes, breakDurationMinutes);
        }

        static void StartingTimer(int workDurationMinutes, int breakDurationMinutes)
        {
            Console.WriteLine("Work Timer Begins.");
            Countdown(workDurationMinutes, "Work");

            Console.WriteLine("Break Time Begins");
            Countdown(breakDurationMinutes, "Break");

            //Restarting Timer
            StartingTimer(workDurationMinutes, breakDurationMinutes);

        }

        public static void Countdown(int durationMinutes, string step)
        {
            int durationSeconds = durationMinutes * 60;
            for (int j = durationSeconds; j > 0; j--)
            {
                Console.WriteLine($"{step} Time Remaining: : {TimeSpan.FromSeconds(j)}");
                Thread.Sleep(3000); //Breaking for 3 seconds
            }

            Console.WriteLine($"{step} TimeSpan Up!");
        }
    }
}
