public class Book
{
    public string Title { get; set; }
    public string Author { get; set; }
    public DateTime PublishDate { get; set; }

    public Book(string title, string author, DateTime publishDate)
    {
        Title = title;
        Author = author;
        PublishDate = publishDate;
    }

    public override string ToString()
    {
        return $"Tytuł: {Title}, Autor: {Author}, Data wydania: {PublishDate.ToShortDateString()}";
    }
}