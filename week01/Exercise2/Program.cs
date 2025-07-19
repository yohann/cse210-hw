using System;

class Program
{
    static void Main()
    {
        Console.Write("What is your grade percentage? ");
        string input = Console.ReadLine() ?? "0";
        int percentage = int.Parse(input);
        
        string letter = "";
        
        if (percentage >= 90)
        {
            letter = "A";
        }
        else if (percentage >= 80)
        {
            letter = "B";
        }
        else if (percentage >= 70)
        {
            letter = "C";
        }
        else if (percentage >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }
        
        string sign = "";
        if (letter != "A" && letter != "F")
        {
            int lastDigit = percentage % 10;
            if (lastDigit >= 7)
            {
                sign = "+";
            }
            else if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        else if (letter == "A")
        {
            int lastDigit = percentage % 10;
            if (lastDigit < 3)
            {
                sign = "-";
            }
        }
        
        Console.WriteLine($"Your letter grade is: {letter}{sign}");
        
        if (percentage >= 70)
        {
            Console.WriteLine("Congratulations! You passed the course!");
        }
        else
        {
            Console.WriteLine("Better luck next time! Keep studying and you'll get it!");
        }
    }
}