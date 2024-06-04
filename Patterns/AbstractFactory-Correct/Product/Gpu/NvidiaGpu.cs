namespace AbstractFactory_Correct.Product.Gpu;

public class NvidiaGpu : IGpu
{
    public void Assemble()
    {
        Console.WriteLine("Made nvidia gpu");
    }
}