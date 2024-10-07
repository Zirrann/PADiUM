public class OrderManager
{
    private static OrderManager _instance;
    private static readonly object _lock = new object();

    private OrderManager() { }

    public static OrderManager Instance
    {
        get
        {
            lock (_lock)
            {
                if (_instance == null)
                {
                    _instance = new OrderManager();
                }
                return _instance;
            }
        }
    }

    public void CreateOrder(Customer customer, List<Product> products, IPaymentStrategy paymentStrategy)
    {
        Order order = OrderFactory.CreateOrder(customer, products);
        order.PaymentStrategy = paymentStrategy;
        order.ProcessPayment();
    }
}