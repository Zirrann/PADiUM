public class Program
{
    public static void Main(string[] args)
    {
        var customer = new Customer
        {
            Name = "Jan Kowalski",
            Email = "jan.kowalski@example.com"
        };

        var product1 = new Product { Name = "Laptop", Price = 3000 };
        var product2 = new Product { Name = "Myszka", Price = 150 };
        var products = new List<Product> { product1, product2 };

        var creditCardPayment = new CreditCardPayment("1234 5678 9012 3456", "Jan Kowalski", "12/25");

        var orderManager = OrderManager.Instance;
        orderManager.CreateOrder(customer, products, creditCardPayment);

        Console.WriteLine("\n---\n");

        var paypalPayment = new PayPalPayment("jan.kowalski@example.com", "sekretnehaslo");
        orderManager.CreateOrder(customer, products, paypalPayment);
    }
}