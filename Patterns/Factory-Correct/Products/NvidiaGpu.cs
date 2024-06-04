namespace Factory_CorrectFactory.Products;

public class NvidiaGpu : IGpu
{
    public void Assemble()
    {
        Console.WriteLine("Assembled NVIDIA GPU");
    }
}