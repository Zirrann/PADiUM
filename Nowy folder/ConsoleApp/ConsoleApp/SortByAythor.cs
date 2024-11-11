public class SortByAuthor : ISortStrategy
{
    public void Sort(List<Book> books)
    {
        books.Sort((x, y) => x.Author.CompareTo(y.Author));
    }
}