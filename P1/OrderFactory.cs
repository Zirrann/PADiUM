public class OrderFactory
{
    public static Order CreateOrder(Customer customer, List<Product> products)
    {
        return new Order { Customer = customer, Products = products };
    }
}