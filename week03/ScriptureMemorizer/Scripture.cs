using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference reference;
    private List<Word> words;
    
    public Scripture(Reference reference, string text)
    {
        this.reference = reference;
        words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void DisplayScripture()
    {
        Console.Clear();
        Console.WriteLine($"{reference.GetReferenceText()}");
        Console.WriteLine(string.Join(" ", words.Select(word => word.GetDisplayText())));
    }

    public void HideWords(int count)
    {
        Random rand = new Random();
        List<Word> visibleWords = words.Where(word => !word.IsHidden()).ToList();
        
        for (int i = 0; i < count && visibleWords.Count > 0; i++)
        {
            Word wordToHide = visibleWords[rand.Next(visibleWords.Count)];
            wordToHide.HideWord();
            visibleWords.Remove(wordToHide);
        }
    }

    public bool AllWordsHidden()
    {
        return words.All(word => word.IsHidden());
    }
}
