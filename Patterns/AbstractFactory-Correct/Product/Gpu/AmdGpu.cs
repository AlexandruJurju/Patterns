namespace AbstractFactory_Correct.Product.Gpu;

public class AmdGpu : IGpu
{
    public void Assemble()
    {
        Console.WriteLine("Made amd gpu");
    }
}