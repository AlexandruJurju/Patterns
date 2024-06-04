using Factory_CorrectFactory.Products;

namespace Factory_CorrectFactory.Factories;

/// <summary>
/// Fix the OCP violation by having a factory class for each product
/// Make the factory class abstract to force the implementation of the creation method for each concrete factory
/// The concrete factory classes return the concrete products
/// </summary>
public abstract class Factory
{
    public IGpu AssembleGpu()
    {
        IGpu gpu = CreateGpu();
        gpu.Assemble();
        return gpu;
    }

    // protected so only assemble can be called / don't return objects directly
    protected abstract IGpu CreateGpu();
}