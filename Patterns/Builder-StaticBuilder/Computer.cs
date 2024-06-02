namespace Builder___StaticBuilder;

public class Computer
{
    public string GPU { get; set; }
    public string CPU { get; set; }
    public int HDD { get; set; }
    public int RAM { get; set; }

    public static ComputerBuilder CreateBuilder()
    {
        return new ComputerBuilder();
    }

    public class ComputerBuilder
    {
        private readonly Computer _computer;

        public ComputerBuilder()
        {
            _computer = new Computer();
        }

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

        public ComputerBuilder SetHdd(int hdd)
        {
            _computer.HDD = hdd;
            return this;
        }

        public ComputerBuilder SetRam(int ram)
        {
            _computer.RAM = ram;
            return this;
        }

        public Computer Build()
        {
            return _computer;
        }
    }
}