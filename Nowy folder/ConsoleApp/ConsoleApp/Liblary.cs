public class Library
{
    private List<Book> books = new List<Book>();
    private ISortStrategy sortStrategy;

    public void SetSortStrategy(ISortStrategy strategy)
    {
        sortStrategy = strategy;
    }

    public void AddBook(Book book)
    {
        books.Add(book);
    }

    public void DisplayBooks()
    {
        if (sortStrategy != null)
        {
            sortStrategy.Sort(books);
        }

        foreach (var book in books)
        {
            Console.WriteLine(book);
        }
    }
}
