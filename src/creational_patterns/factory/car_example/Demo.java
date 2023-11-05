package creational_patterns.factory.car_example;

import creational_patterns.factory.car_example.cars.Car;
import creational_patterns.factory.car_example.factories.CarFactory;
import creational_patterns.factory.car_example.factories.SedanFactory;

public class Demo {
    public static void main(String[] args) {
        CarFactory factory = new SedanFactory();
        Car sedan = factory.createCar("Sedan", "GOOD", 20, "Black");
    }
}
