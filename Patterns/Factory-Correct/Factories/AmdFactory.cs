using Factory_CorrectFactory.Products;

namespace Factory_CorrectFactory.Factories;

public class AmdFactory : Factory
{
    protected override IGpu CreateGpu()
    {
        return new AmdGpu();
    }
}