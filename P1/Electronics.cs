public class Electronics : Product
{
    public string Brand { get; set; }

    public override void DisplayInfo()
    {
        Console.WriteLine($"Elektronika: {Name}, Marka: {Brand}");
    }
}