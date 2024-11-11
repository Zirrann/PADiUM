public class User : IOrderObserver
{
    public string Name { get; set; }

    public User(string name)
    {
        Name = name;
    }

    public void Update(string orderStatus)
    {
        Console.WriteLine($"Użytkownik {Name} został powiadomiony o zmianie statusu zamówienia: {orderStatus}");
    }
}