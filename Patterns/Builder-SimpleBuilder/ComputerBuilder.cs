namespace Builder_SimpleBuilder;

public class ComputerBuilder
{
    private readonly Computer _computer = new Computer();

    public ComputerBuilder SetGpu(string gpu)
    {
        _computer.GPU = gpu;
        return this;
    }
    
    public ComputerBuilder SetCpu(string cpu)
    {
        _computer.CPU = cpu;
        return this;
    }
    
        
    public ComputerBuilder SetRam(int ram)
    {
        _computer.RAM = ram;
        return this;
    }

    public ComputerBuilder SetHdd(int hdd)
    {
        _computer.HDD = hdd;
        return this;
    }

    public Computer Build()
    {
        return _computer;
    }
}