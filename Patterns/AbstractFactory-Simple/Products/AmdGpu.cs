namespace AbstractFactory_Simple.Products;

public class AmdGpu : IComponent
{
    public void Assemble()
    {
        Console.WriteLine("Assembled Amd GPU");
    }
}