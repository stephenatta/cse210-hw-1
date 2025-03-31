
public class Assignment
{
    private string _studentName;
    private string _topic;

    // Constructor
    public Assignment(string studentName, string topic)
    {
        _studentName = studentName;
        _topic = topic;
    }

    // GetSummary Method
    public string GetSummary()
    {
        return $"{_studentName} - {_topic}";
    }
}
