using System;

class Program
{
    static void Main()
    {
        DisplayWelcome();
        
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        
        int squaredNumber = SquareNumber(userNumber);
        
        DisplayResult(userName, squaredNumber);
    }
    
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }
    
    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine() ?? string.Empty;
        return name;
    }
    
    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string input = Console.ReadLine() ?? "0";
        int number = int.Parse(input);
        return number;
    }
    
    static int SquareNumber(int number)
    {
        int square = number * number;
        return square;
    }
    
    static void DisplayResult(string name, int square)
    {
        Console.WriteLine($"{name}, the square of your number is {square}");
    }
}