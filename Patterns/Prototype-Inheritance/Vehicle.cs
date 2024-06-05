namespace Prototype_Inheritance;

public abstract class Vehicle
{
    public string Brand { get; set; }
    public string Model { get; set; }
    public string Color { get; set; }


    protected Vehicle(Vehicle vehicle)
    {
        Brand = vehicle.Brand;
        Model = vehicle.Model;
        Color = vehicle.Color;
    }

    public abstract Vehicle Clone();
}