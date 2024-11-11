public abstract class BookDecorator : Book
{
    protected Book book;

    protected BookDecorator(Book book) : base(book.Title, book.Author, book.PublishDate)
    {
        this.book = book;
    }

    public abstract override string ToString();
}