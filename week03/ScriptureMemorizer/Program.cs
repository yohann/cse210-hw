using System;

class Program
{
    static void Main(string[] args)
    {
        // W03 Project: Scripture Memorizer Program
        // Exceeding requirements: You can easily add more scriptures to the list below for random selection.
        var scriptures = new[] {
            new Scripture(
                new Reference("Proverbs", 3, 5, 6),
                "Trust in the Lord with all thine heart and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths."),
            new Scripture(
                new Reference("John", 3, 16),
                "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.")
        };
        var rand = new Random();
        var scripture = scriptures[rand.Next(scriptures.Length)];
        const int wordsToHide = 3;

        while (true)
        {
            Console.Clear();
            Console.WriteLine(scripture.GetDisplayText());
            if (scripture.AllWordsHidden())
            {
                Console.WriteLine("\nAll words are hidden. Program will now end.");
                break;
            }
            Console.WriteLine("\nPress Enter to hide words or type 'quit' to exit.");
            string input = Console.ReadLine();
            if (input.Trim().ToLower() == "quit")
                break;
            scripture.HideRandomWords(wordsToHide);
        }
    }
}