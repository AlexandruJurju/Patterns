namespace Observer_List;

public class ConcreteObserverA : IObserver
{
    public void Update(int number)
    {
        Console.WriteLine($"ConcreteObserverA notified with {number}");
    }
}