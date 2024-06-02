namespace Builder_SimpleBuilder;

class Program
{
    static void Main(string[] args)
    {
        Computer computer = new ComputerBuilder()
            .SetGpu("Nvidia")
            .SetCpu("Intel")
            .SetHdd(128)
            .SetRam(16)
            .Build();
    }
}