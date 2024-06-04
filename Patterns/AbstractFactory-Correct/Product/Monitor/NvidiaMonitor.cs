namespace AbstractFactory_Correct.Product.Monitor;

public class NvidiaMonitor : IMonitor
{
    public void Assemble()
    {
        Console.WriteLine("Made nvidia monitor");
    }
}