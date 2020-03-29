package creational.factory.abstractfactory.factories;

import creational.factory.abstractfactory.autos.*;

public class BMWFactory implements AutoFactory {
    @Override
    public Auto createSportsCar() {
        return new BMWM3();
    }

    @Override
    public Auto createLuxuryCar() {
        return new BMW740i();
    }

    @Override
    public Auto createEconomyCar() {
        return new BMW328i();
    }
}
