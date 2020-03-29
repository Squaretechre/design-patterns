package creational.factory.abstractfactory.factories;

import creational.factory.abstractfactory.autos.Auto;

public interface AutoFactory {
    Auto createSportsCar();
    Auto createLuxuryCar();
    Auto createEconomyCar();
}
