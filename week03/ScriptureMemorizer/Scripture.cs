// Scripture.cs - Manages scripture text and word hiding
using System;
using System.Collections.Generic;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    // Constructor: Takes reference and scripture text
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        // Split the text into words and store them in the list
        string[] wordsArray = text.Split(" ");
        foreach (string word in wordsArray)
        {
            _words.Add(new Word(word));
        }
    }

    // Hides a given number of random words
    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int hiddenCount = 0;

        while (hiddenCount < numberToHide)
        {
            int index = random.Next(_words.Count);
            if (!_words[index].IsHidden()) // Hide only if not already hidden
            {
                _words[index].Hide();
                hiddenCount++;
            }
        }
    }

    // Returns the scripture with hidden words
    public string GetDisplayText()
    {
        string scriptureText = _reference.GetDisplayText() + " - ";
        foreach (Word word in _words)
        {
            scriptureText += word.GetDisplayText() + " ";
        }
        return scriptureText.Trim();
    }

    // Checks if all words are hidden
    public bool IsCompletelyHidden()
    {
        foreach (Word word in _words)
        {
            if (!word.IsHidden())
                return false;
        }
        return true;
    }
}
