package creational.factory.factorymethod.factories;

import creational.factory.factorymethod.autos.Auto;
import creational.factory.factorymethod.autos.MiniCooper;

public class MiniCooperFactory implements AutoFactory {
    @Override
    public Auto createAutomobile() {
        // Handle object specific configuration
        return new MiniCooper("Mini Cooper S");
    }
}
