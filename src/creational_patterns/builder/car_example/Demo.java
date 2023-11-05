package creational_patterns.builder.car_example;

import creational_patterns.builder.car_example.builders.CarBuilder;

public class Demo {
    public static void main(String[] args) {
        Director director = new Director();
        CarBuilder builder = new CarBuilder();
        director.constructSportsCar(builder);
    }
}
