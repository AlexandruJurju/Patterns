namespace Observer_List;

class Program
{
    static void Main(string[] args)
    {
        var subject = new Subject();
        var observerA = new ConcreteObserverA();
        var observerB = new ConcreteObserverB();
        subject.Attach(observerA);
        subject.Attach(observerB);
        
        
        subject.ChangeState();
        subject.ChangeState();
    }
}