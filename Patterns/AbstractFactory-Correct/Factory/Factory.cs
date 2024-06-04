using AbstractFactory_Correct.Product.Gpu;
using AbstractFactory_Correct.Product.Monitor;

namespace AbstractFactory_Correct.Factory;

public abstract class Factory
{
    public abstract IGpu CreateGpu();

    public abstract IMonitor CreateMonitor();
}