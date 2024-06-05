namespace Prototype;

public class Car : IPrototype
{
    public string Model { get; set; }
    public string Color { get; set; }
    public int Horsepower { get; set; }

    public Car()
    {
    }

    public Car(Car car)
    {
        this.Color = car.Color;
        this.Horsepower = car.Horsepower;
        this.Model = car.Model;
    }

    public Car Clone()
    {
        return new Car(this);
    }
}