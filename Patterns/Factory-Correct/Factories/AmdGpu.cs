using Factory_CorrectFactory.Products;

namespace Factory_CorrectFactory.Factories;

public class AmdGpu : IGpu
{
    public void Assemble()
    {
        Console.WriteLine("Assembled AMD GPU");
    }
}