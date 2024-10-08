public class Order
{
    private string status;
    private List<IOrderObserver> observers = new List<IOrderObserver>();

    public string Status
    {
        get { return status; }
        set
        {
            status = value;
            NotifyObservers();
        }
    }

    public void Attach(IOrderObserver observer)
    {
        observers.Add(observer);
    }

    public void Detach(IOrderObserver observer)
    {
        observers.Remove(observer);
    }

    private void NotifyObservers()
    {
        foreach (var observer in observers)
        {
            observer.Update(status);
        }
    }
}