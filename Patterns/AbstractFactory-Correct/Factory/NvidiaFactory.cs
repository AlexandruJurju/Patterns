using AbstractFactory_Correct.Product.Gpu;
using AbstractFactory_Correct.Product.Monitor;

namespace AbstractFactory_Correct.Factory;

public class NvidiaFactory : Factory
{
    public override IGpu CreateGpu()
    {
        return new NvidiaGpu();
    }

    public override IMonitor CreateMonitor()
    {
        return new NvidiaMonitor();
    }
}