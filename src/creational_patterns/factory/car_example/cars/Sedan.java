package creational_patterns.factory.car_example.cars;

public class Sedan extends Car {
    public Sedan(String make, String model, int year, String color) {
        super(make, model, year, color);
    }

    @Override
    public void start() {
        System.out.println("Sedan START");
    }

    @Override
    public void stop() {
        System.out.println("Sedan STOP");
    }
}
