package creational.factory.factorymethod.factories;

import creational.factory.factorymethod.autos.Auto;
import creational.factory.factorymethod.autos.NullCar;

public class NullCarFactory implements AutoFactory {
    @Override
    public Auto createAutomobile() {
        return new NullCar();
    }
}
