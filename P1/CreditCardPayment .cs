public class CreditCardPayment : IPaymentStrategy
{
    private string _cardNumber;
    private string _cardHolderName;
    private string _expirationDate;

    public CreditCardPayment(string cardNumber, string cardHolderName, string expirationDate)
    {
        _cardNumber = cardNumber;
        _cardHolderName = cardHolderName;
        _expirationDate = expirationDate;
    }

    public void Pay(decimal amount)
    {
        Console.WriteLine($"Płatność kartą na {amount:C}, karta: {_cardNumber}, właściciel: {_cardHolderName}, ważna do: {_expirationDate}.");
    }
}