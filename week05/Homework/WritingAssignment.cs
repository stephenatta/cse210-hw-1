// WritingAssignment.cs
public class WritingAssignment : Assignment
{
    private string _title;

    // Constructor
    public WritingAssignment(string studentName, string topic, string title) 
        : base(studentName, topic)
    {
        _title = title;
    }

    // GetWritingInformation Method
    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }

    // GetStudentName Method (to access private member)
    public string GetStudentName()
    {
        return base.GetSummary().Split(" - ")[0]; // Gets only the student's name
    }
}
