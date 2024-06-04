namespace AbstractFactory_Correct.Product.Monitor;

public class AmdMonitor : IMonitor
{
    public void Assemble()
    {
        Console.WriteLine("Made amd monitor");
    }
}