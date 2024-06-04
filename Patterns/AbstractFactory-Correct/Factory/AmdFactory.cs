using AbstractFactory_Correct.Product.Gpu;
using AbstractFactory_Correct.Product.Monitor;

namespace AbstractFactory_Correct.Factory;

public class AmdFactory : Factory
{
    public override IGpu CreateGpu()
    {
        return new AmdGpu();
    }

    public override IMonitor CreateMonitor()
    {
        return new AmdMonitor();
    }
}