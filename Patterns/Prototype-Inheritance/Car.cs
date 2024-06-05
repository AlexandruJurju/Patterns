namespace Prototype_Inheritance;

public class Car : Vehicle
{
    public int TopSpeed { get; set; }

    public Car(Car car) : base(car)
    {
        TopSpeed = car.TopSpeed;
    }

    public override Vehicle Clone()
    {
        return new Car(this);
    }
}