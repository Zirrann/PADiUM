public class Program
{
    public static void Main(string[] args)
    {
        // Tworzenie produktów
        var db = Database.GetInstance();
        var book = ProductFactory.CreateProduct("book");
        book.Name = "C# Programming";
        ((Book)book).Author = "John Doe";
        db.AddProduct(book);

        var electronics = ProductFactory.CreateProduct("electronics");
        electronics.Name = "Smartphone";
        ((Electronics)electronics).Brand = "Brand X";
        db.AddProduct(electronics);

        // Wyświetlanie produktów
        foreach (var product in db.GetProducts())
        {
            product.DisplayInfo();
        }

        // Tworzenie zamówienia i powiadamianie użytkowników
        var order = new Order();
        var user1 = new User("Alice");
        var user2 = new User("Bob");

        order.Attach(user1);
        order.Attach(user2);

        // Zmiana statusu zamówienia
        order.Status = "Złożono";
        order.Status = "Wysłano";
    }
}