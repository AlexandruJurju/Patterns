using Factory_CorrectFactory.Factories;

namespace Factory_CorrectFactory.Products;

public class NvidiaFactory : Factory
{
    protected override IGpu CreateGpu()
    {
        return new NvidiaGpu();
    }
}