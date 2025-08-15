using System;
using System.Collections.Generic;

namespace ExerciseTracking
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise Tracking Program");
            Console.WriteLine("========================");

            List<Activity> activities = new List<Activity>();

            // Create running activity
            Running running = new Running(new DateTime(2022, 11, 3), 30, 3.0);
            activities.Add(running);

            // Create cycling activity
            Cycling cycling = new Cycling(new DateTime(2022, 11, 3), 30, 6.0);
            activities.Add(cycling);

            // Create swimming activity
            Swimming swimming = new Swimming(new DateTime(2022, 11, 3), 30, 20);
            activities.Add(swimming);

            // Display summaries for all activities
            foreach (Activity activity in activities)
            {
                Console.WriteLine(activity.GetSummary());
            }
        }
    }
}