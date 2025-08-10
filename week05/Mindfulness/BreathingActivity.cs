using System;

public class BreathingActivity : Activity
{
    private int _rounds;
    private int _breathsPerRound;

    public BreathingActivity() : base("Breathing Activity", "This activity will guide you through the Wim Hof breathing method. This technique involves controlled hyperventilation followed by breath retention, which may help reduce stress and increase energy. Please consult a healthcare provider before starting if you have any medical conditions.")
    {
        _rounds = 3;
        _breathsPerRound = 30;
    }

    public override void Run()
    {
        DisplayStartingMessage();

        Console.WriteLine();
        Console.WriteLine("The Wim Hof method consists of 3 rounds:");
        Console.WriteLine("1. 30 deep breaths (inhale fully, exhale naturally)");
        Console.WriteLine("2. Hold your breath after the last exhale");
        Console.WriteLine("3. Take a recovery breath and hold for 15 seconds");
        Console.WriteLine();
        Console.WriteLine("Press enter to begin...");
        Console.ReadLine();

        for (int round = 1; round <= _rounds; round++)
        {
            Console.Clear();
            Console.WriteLine($"=== Round {round} of {_rounds} ===");
            Console.WriteLine();

            // Phase 1: 30 breaths
            Console.WriteLine("Phase 1: Deep breathing");
            Console.WriteLine("Breathe in fully through your nose, breathe out naturally through your mouth");
            Console.WriteLine();
            Console.WriteLine("Press enter to start the breathing cycle...");
            Console.ReadLine();

            for (int breath = 1; breath <= _breathsPerRound; breath++)
            {
                Console.Write($"Breath {breath}: ");
                Console.Write("Breathe IN deeply... ");
                ShowCountDown(2);
                Console.Write("breathe out naturally... ");
                ShowCountDown(1);
                Console.WriteLine();
            }

            // Phase 2: Breath retention
            Console.WriteLine();
            Console.WriteLine("Phase 2: Breath Retention");
            Console.WriteLine("After your last exhale, hold your breath for as long as comfortable.");
            Console.WriteLine("Press enter when you need to breathe again...");
            Console.WriteLine();
            Console.Write("Holding breath... ");

            DateTime holdStart = DateTime.Now;
            Console.ReadLine();
            DateTime holdEnd = DateTime.Now;
            int holdDuration = (int)(holdEnd - holdStart).TotalSeconds;

            Console.WriteLine($"Great! You held your breath for {holdDuration} seconds.");

            // Phase 3: Recovery breath
            Console.WriteLine();
            Console.WriteLine("Phase 3: Recovery breath");
            Console.WriteLine("Take a deep breath in and hold for 15 seconds...");
            Console.Write("Breathe in deeply and hold... ");
            ShowCountDown(15);
            Console.WriteLine("Release!");
            Console.WriteLine();

            if (round < _rounds)
            {
                Console.WriteLine("Well done! Prepare for the next round...");
                ShowSpinner(3);
            }
        }

        Console.WriteLine();
        Console.WriteLine("Congratulations! You have completed all 3 rounds of the Wim Hof breathing method.");

        DisplayEndingMessage();
    }
}
