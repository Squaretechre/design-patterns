package creational.factory.abstractfactory.factories;

import creational.factory.abstractfactory.autos.Auto;
import creational.factory.abstractfactory.autos.NullCar;

public class NullCarFactory implements AutoFactory {
    @Override
    public Auto createSportsCar() {
        return new NullCar();
    }

    @Override
    public Auto createLuxuryCar() {
        return new NullCar();
    }

    @Override
    public Auto createEconomyCar() {
        return new NullCar();
    }
}
