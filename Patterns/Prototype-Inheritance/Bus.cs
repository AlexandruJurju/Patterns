namespace Prototype_Inheritance;

public class Bus : Vehicle
{
    public int Weight { get; set; }

    public Bus(Bus bus) : base(bus)
    {
        Weight = bus.Weight;
    }

    public override Vehicle Clone()
    {
        return new Bus(this);
    }
}