public class PayPalPayment : IPaymentStrategy
{
    private string _email;
    private string _password;

    public PayPalPayment(string email, string password)
    {
        _email = email;
        _password = password;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Płatność PayPal na {amount:C} z konta: {_email}.");
    }
}