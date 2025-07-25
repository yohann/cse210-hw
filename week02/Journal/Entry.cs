using System;

public class Entry
{
    public string _date;
    public string _promptText;
    public string _entryText;

    public Entry()
    {
        _date = "";
        _promptText = "";
        _entryText = "";
    }

    public Entry(string date, string promptText, string entryText)
    {
        _date = date;
        _promptText = promptText;
        _entryText = entryText;
    }

    public void Display()
    {
        Console.WriteLine($"Date: {_date} - Prompt: {_promptText}");
        Console.WriteLine(_entryText);
        Console.WriteLine();
    }
}
