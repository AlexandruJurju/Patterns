namespace Factory_CorrectFactory.Products;

public class AmdGpu : IGpu
{
    public void Assemble()
    {
        Console.WriteLine("Assembled AMD GPU");
    }
}