// Extra Creativity: Added a leveling system where players gain levels every 1000 points earned,
// providing progression tracking and additional motivation for achieving goals.

using System;

class Program
{
    static void Main(string[] args)
    {
        GoalManager manager = new GoalManager();
        manager.Start();
    }
}