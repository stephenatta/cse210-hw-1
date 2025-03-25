//Stores the scripture reference
using System;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endVerse; // For multi-verse references

    // Constructor for single-verse reference
    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = -1; // Indicates no end verse
    }

    // Constructor for multi-verse reference
    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _verse = verse;
        _endVerse = endVerse;
    }

    // Returns formatted reference string
    public string GetDisplayText()
    {
        if (_endVerse == -1)
            return $"{_book} {_chapter}:{_verse}";
        else
            return $"{_book} {_chapter}:{_verse}-{_endVerse}";
    }
}
