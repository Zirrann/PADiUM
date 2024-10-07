public class Order
{
    public Customer Customer { get; set; }
    public List<Product> Products { get; set; } = new List<Product>();
    public decimal TotalAmount => CalculateTotalAmount();
    public IPaymentStrategy PaymentStrategy { get; set; }

    private decimal CalculateTotalAmount()
    {
        decimal total = 0;
        foreach (var product in Products)
        {
            total += product.Price;
        }
        return total;
    }

    public void ProcessPayment()
    {
        if (PaymentStrategy == null)
        {
            Console.WriteLine("Błąd: nie wybrano metody płatności.");
            return;
        }

        Console.WriteLine($"Rozpoczęcie procesu płatności dla zamówienia o wartości {TotalAmount:C}");
        PaymentStrategy.Pay(TotalAmount);
    }
}