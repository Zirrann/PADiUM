public class ProductFactory
{
    public static Product CreateProduct(string type)
    {
        switch (type)
        {
            case "book":
                return new Book();
            case "electronics":
                return new Electronics();
            default:
                throw new Exception("Unknown product type");
        }
    }
}