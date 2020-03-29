package creational.factory.abstractfactory.factories;

import creational.factory.abstractfactory.autos.Auto;
import creational.factory.abstractfactory.autos.MiniCooper;

public class MiniCooperFactory implements AutoFactory {
    @Override
    public Auto createSportsCar() {
        return new MiniCooper("Mini Cooper S");
    }

    @Override
    public Auto createLuxuryCar() {
        return new MiniCooper("Mini Cooper with leather upholstery");
    }

    @Override
    public Auto createEconomyCar() {
        return new MiniCooper("Mini Cooper");
    }
}
