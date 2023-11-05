package creational_patterns.factory.car_example.cars;

public class SUV extends Car {
    public SUV(String make, String model, int year, String color) {
        super(make, model, year, color);
    }

    @Override
    public void start() {
        System.out.println("SUV START");
    }

    @Override
    public void stop() {
        System.out.println("SUV STOP");
    }
}
