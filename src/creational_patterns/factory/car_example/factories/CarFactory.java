package creational_patterns.factory.car_example.factories;

import creational_patterns.factory.car_example.cars.Car;

public interface CarFactory {
    Car createCar(String make, String model, int year, String color);
}
