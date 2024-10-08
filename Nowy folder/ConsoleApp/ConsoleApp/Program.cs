public class Program
{
    public static void Main(string[] args)
    {
        Library library = new Library();

        library.AddBook(new Book("C# Programming", "John Doe", new DateTime(2020, 1, 1)));
        library.AddBook(new Book("Design Patterns", "Erich Gamma", new DateTime(1994, 1, 1)));
        library.AddBook(new Book("Clean Code", "Robert C. Martin", new DateTime(2008, 1, 1)));

        var ratedBook = new RatedBook(new Book("C# Programming", "John Doe", new DateTime(2020, 1, 1)), 4.5);
        var notedBook = new NotedBook(new Book("Clean Code", "Robert C. Martin", new DateTime(2008, 1, 1)), "Bardzo ważna książka");

        library.AddBook(ratedBook);
        library.AddBook(notedBook);

        library.SetSortStrategy(new SortByTitle());

        Console.WriteLine("Książki posortowane według daty publikacji:");
        library.DisplayBooks();

        library.SetSortStrategy(new SortByAuthor());

        Console.WriteLine("\nKsiążki posortowane według autora:");
        library.DisplayBooks();
    }
}