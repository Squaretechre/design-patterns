package creational.factory.factorymethod.factories;

import creational.factory.factorymethod.autos.Auto;
import creational.factory.factorymethod.autos.BMWM5Cabriolet;

public class BMWFactory implements AutoFactory {
    @Override
    public Auto createAutomobile() {
        // Handle object specific configuration
        return new BMWM5Cabriolet();
    }
}
