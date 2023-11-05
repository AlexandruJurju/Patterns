package creational_patterns.factory.car_example.cars;

public abstract class Car {
    private String make;
    private String model;
    private int year;
    private String color;

    public abstract void start();

    public abstract void stop();

    public Car(String make, String model, int year, String color) {
        this.make = make;
        this.model = model;
        this.year = year;
        this.color = color;
    }
}
