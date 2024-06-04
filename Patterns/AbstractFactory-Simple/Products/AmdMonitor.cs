namespace AbstractFactory_Simple.Products;

public class AmdMonitor : IComponent
{
    public void Assemble()
    {
        Console.WriteLine("Assembled Amd Monitor");
    }
}