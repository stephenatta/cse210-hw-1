using System;

public class Entry
{
    public string _date; // Date of the journal entry
    public string _prompt; // The prompt given to the user
    public string _response; // The user's response to the prompt
    

    // Constructor to initialize a new Entry object
    public Entry(string date, string prompt, string response)
    {
        _date = date;
        _prompt = prompt; 
        _response = response;
    }
    // Displays the entry in a formatted manner
    public void Display()
    {
        Console.WriteLine($"Date: {_date}\nPrompt: {_prompt}\nResponse: {_response}\n");
    }
}
