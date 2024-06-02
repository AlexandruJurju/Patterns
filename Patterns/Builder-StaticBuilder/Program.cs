namespace Builder___StaticBuilder;

class Program
{
    static void Main(string[] args)
    {
        Computer computer = Computer.CreateBuilder()
            .SetGpu("NVIDIA GTX 3080")
            .SetCpu("Intel i9")
            .SetHdd(2000)
            .SetRam(32)
            .Build();
    }
}