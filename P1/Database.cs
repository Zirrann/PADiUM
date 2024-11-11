public class Database
{
    private static Database instance;
    private List<Product> products;
    private Database()
    {
        products = new List<Product>();
    }

    public static Database GetInstance()
    {
        if (instance == null)
        {
            instance = new Database();
        }

        return instance;
    }

    public void AddProduct(Product product)
    {
        products.Add(product);
    }

    public List<Product> GetProducts()
    {
        return products;
    }
}