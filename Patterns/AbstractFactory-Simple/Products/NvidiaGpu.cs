namespace AbstractFactory_Simple.Products;

public class NvidiaGpu : IComponent
{
    public void Assemble()
    {
        Console.WriteLine("Assembled Nvidia GPU");
    }
}