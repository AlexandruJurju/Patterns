using AbstractFactory_Simple.Products;

namespace AbstractFactory_Simple.Factory;

public class AmdFactory : Factory
{
    public override IComponent CreateComponent(Product product)
    {
        switch (product)
        {
            case Product.Monitor:
                return new AmdMonitor();
            case Product.Gpu:
                return new AmdGpu();
            default:
                throw new Exception();
        }
    }
}