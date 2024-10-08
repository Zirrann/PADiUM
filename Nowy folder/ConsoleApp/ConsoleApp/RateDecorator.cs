public class RatedBook : BookDecorator
{
    public double Rating { get; set; }

    public RatedBook(Book book, double rating) : base(book)
    {
        Rating = rating;
    }

    public override string ToString()
    {
        return $"{book.ToString()}, Ocena: {Rating}";
    }
}