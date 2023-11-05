package creational_patterns.builder.car_example.builders;

import creational_patterns.builder.car_example.cars.CarType;
import creational_patterns.builder.car_example.components.Engine;
import creational_patterns.builder.car_example.components.GPSNavigator;
import creational_patterns.builder.car_example.components.Transmission;
import creational_patterns.builder.car_example.components.TripComputer;

public interface Builder {
    void setCarType(CarType type);

    void setSeats(int seats);

    void setEngine(Engine Engine);

    void setTransmission(Transmission transmission);

    void setTripComputer(TripComputer tripComputer);

    void setGPSNavigator(GPSNavigator gpsNavigator);


}
