using Factory_CorrectFactory.Products;

namespace Factory_CorrectFactory.Factories;

public class NvidiaFactory : Factory
{
    protected override IGpu CreateGpu()
    {
        return new NvidiaGpu();
    }
}