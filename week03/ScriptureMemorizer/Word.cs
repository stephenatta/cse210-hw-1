//Represents a single word in the scripture
using System;

public class Word
{
    private string _text;
    private bool _isHidden;

    // Constructor: Word starts as visible
    public Word(string text)
    {
        _text = text;
        _isHidden = false;
    }

    // Hide the word
    public void Hide()
    {
        _isHidden = true;
    }

    // Show the word (for future use)
    public void Show()
    {
        _isHidden = false;
    }

    // Check if the word is hidden
    public bool IsHidden()
    {
        return _isHidden;
    }

    // Returns either the word or underscores
    public string GetDisplayText()
    {
        return _isHidden ? "_____" : _text;
    }
}
