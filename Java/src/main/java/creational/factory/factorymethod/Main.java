package creational.factory.factorymethod;

import creational.factory.factorymethod.autos.Auto;
import creational.factory.factorymethod.factories.AutoFactory;
import creational.factory.factorymethod.factories.MiniCooperFactory;

public class Main {
    public static void main(String... args) {
        AutoFactory factory = loadFactory();

        Auto car = factory.createAutomobile();

        car.turnOn();
        car.turnOff();
    }

    private static AutoFactory loadFactory() {
        return new MiniCooperFactory();
    }
}
