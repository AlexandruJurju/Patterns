package creational_patterns.factory.car_example.factories;

import creational_patterns.factory.car_example.cars.Car;
import creational_patterns.factory.car_example.cars.Sedan;

public class SedanFactory implements CarFactory {
    @Override
    public Car createCar(String make, String model, int year, String color) {
        return new Sedan(make, model, year, color);
    }
}
