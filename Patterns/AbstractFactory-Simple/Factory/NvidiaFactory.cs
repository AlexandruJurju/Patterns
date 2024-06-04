using AbstractFactory_Simple.Products;

namespace AbstractFactory_Simple.Factory;

public class NvidiaFactory : Factory
{
    public override IComponent CreateComponent(Product product)
    {
        switch (product)
        {
            case Product.Monitor:
                return new NvidiaMonitor();
            case Product.Gpu:
                return new NvidiaGpu();
            default:
                throw new Exception();
        }
    }
}