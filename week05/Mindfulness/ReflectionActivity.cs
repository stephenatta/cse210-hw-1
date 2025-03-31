using System;
using System.Collections.Generic;

class ReflectionActivity : Activity
{
    private static readonly List<string> _prompts = new()
    {
        "Think of a time you overcame a challenge.",
        "Recall a moment when you felt truly happy.",
        "What is one lesson you've learned from failure?"
    };

    private static List<string> _availablePrompts = new(_prompts);

    public ReflectionActivity(int duration)
        : base("Reflection Exercise", "Ponder a meaningful question and reflect.", duration) { }

    private string GetRandomPrompt()
    {
        if (_availablePrompts.Count == 0)
            _availablePrompts = new List<string>(_prompts);

        Random random = new();
        int index = random.Next(_availablePrompts.Count);
        string prompt = _availablePrompts[index];
        _availablePrompts.RemoveAt(index);
        return prompt;
    }

    public override void Run()
    {
        DisplayStartingMessage();
        Console.WriteLine($"Prompt: {GetRandomPrompt()}");
        AnimationHelper.ShowSpinner(_duration);
        DisplayEndingMessage();
    }
}
