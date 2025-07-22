using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    public Reference Reference { get; private set; }
    private List<Word> _words;
    private Random _random = new Random();

    public Scripture(Reference reference, string text)
    {
        Reference = reference;
        _words = text.Split(' ').Select(w => new Word(w)).ToList();
    }

    public bool AllWordsHidden()
    {
        return _words.All(w => w.IsHidden);
    }

    public void HideRandomWords(int count)
    {
        var notHidden = _words.Where(w => !w.IsHidden).ToList();
        if (notHidden.Count == 0) return;
        for (int i = 0; i < count && notHidden.Count > 0; i++)
        {
            int idx = _random.Next(notHidden.Count);
            notHidden[idx].Hide();
            notHidden.RemoveAt(idx);
        }
    }

    public string GetDisplayText()
    {
        return Reference.ToString() + "\n" + string.Join(" ", _words.Select(w => w.GetDisplayText()));
    }
}

