public class NotedBook : BookDecorator
{
    public string Note { get; set; }

    public NotedBook(Book book, string note) : base(book)
    {
        Note = note;
    }

    public override string ToString()
    {
        return $"{book.ToString()}, Notatka: {Note}";
    }
}