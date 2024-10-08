public class Book : Product
{
    public string Author { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Książka: {Name}, Autor: {Author}");
    }
}