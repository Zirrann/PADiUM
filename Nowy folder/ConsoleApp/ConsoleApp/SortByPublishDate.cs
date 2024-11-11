public class SortByPublishDate : ISortStrategy
{
    public void Sort(List<Book> books)
    {
        books.Sort((x, y) => x.PublishDate.CompareTo(y.PublishDate));
    }
}