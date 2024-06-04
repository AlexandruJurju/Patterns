namespace AbstractFactory_Simple.Products;

public class NvidiaMonitor : IComponent
{
    public void Assemble()
    {
        Console.WriteLine("Assembled Nvidia Monitor");
    }
}