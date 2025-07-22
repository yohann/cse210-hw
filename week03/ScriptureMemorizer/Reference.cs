using System;

public class Reference
{
    public string Book { get; private set; }
    public int StartChapter { get; private set; }
    public int StartVerse { get; private set; }
    public int? EndChapter { get; private set; }
    public int? EndVerse { get; private set; }

    public Reference(string book, int chapter, int verse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = verse;
        EndChapter = null;
        EndVerse = null;
    }

    public Reference(string book, int startChapter, int startVerse, int endChapter, int endVerse)
    {
        Book = book;
        StartChapter = startChapter;
        StartVerse = startVerse;
        EndChapter = endChapter;
        EndVerse = endVerse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        Book = book;
        StartChapter = chapter;
        StartVerse = startVerse;
        EndChapter = chapter;
        EndVerse = endVerse;
    }

    public override string ToString()
    {
        if (EndChapter == null || EndVerse == null)
            return $"{Book} {StartChapter}:{StartVerse}";
        if (StartChapter == EndChapter)
            return $"{Book} {StartChapter}:{StartVerse}-{EndVerse}";
        return $"{Book} {StartChapter}:{StartVerse}-{EndChapter}:{EndVerse}";
    }
}

