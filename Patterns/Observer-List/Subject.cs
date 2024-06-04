﻿namespace Observer_List;

public class Subject : ISubject
{
    private readonly List<IObserver> _observers = new();
    public int State { get; set; } = 0;

    public void Attach(IObserver observer)
    {
        _observers.Add(observer);
    }

    public void Detach(IObserver observer)
    {
        _observers.Remove(observer);
    }

    public void Notify()
    {
        foreach (var observer in _observers)
        {
            observer.Update(State);
        }
    }

    public void ChangeState()
    {
        State = new Random().Next(0, 100);
        Notify();
    }
}