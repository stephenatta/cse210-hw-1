public class Reference
{
    private string book;
    private int chapter;
    private int startVerse;
    private int endVerse;

    public Reference(string book, int chapter, int startVerse, int endVerse = -1)
    {
        this.book = book;
        this.chapter = chapter;
        this.startVerse = startVerse;
        this.endVerse = endVerse;
    }

    public string GetReferenceText()
    {
        return endVerse == -1 ? $"{book} {chapter}:{startVerse}" : $"{book} {chapter}:{startVerse}-{endVerse}";
    }
}
