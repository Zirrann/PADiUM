public interface ISortStrategy
{
    void Sort(List<Book> books);
}

public class SortByTitle : ISortStrategy
{
    public void Sort(List<Book> books)
    {
        books.Sort((x, y) => x.Title.CompareTo(y.Title));
    }
}