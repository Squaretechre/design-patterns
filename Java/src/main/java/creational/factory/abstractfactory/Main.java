package creational.factory.abstractfactory;

import creational.factory.abstractfactory.autos.Auto;
import creational.factory.abstractfactory.factories.AutoFactory;
import creational.factory.abstractfactory.factories.NullCarFactory;
import org.apache.commons.io.IOUtils;

import java.io.IOException;
import java.lang.reflect.InvocationTargetException;
import java.nio.charset.Charset;

public class Main {
    public static void main(String... args) {
        AutoFactory factory = loadFactory();

        System.out.println("SPORTS CAR");
        Auto car = factory.createSportsCar();
        car.turnOn();
        car.turnOff();

        System.out.println("LUXURY CAR");
        car = factory.createLuxuryCar();
        car.turnOn();
        car.turnOff();

        System.out.println("ECONOMY CAR");
        car = factory.createEconomyCar();
        car.turnOn();
        car.turnOff();
    }

    private static AutoFactory loadFactory() {
        try {
            var settingsPath = Main.class.getClassLoader().getResourceAsStream("abstract-factory-settings.txt");
            var settings = IOUtils.toString(settingsPath, Charset.defaultCharset());
            return (AutoFactory) Class.forName(settings).getDeclaredConstructor().newInstance();
        } catch (IOException | ClassNotFoundException e) {
           System.out.println(e.getMessage());
        } catch (IllegalAccessException | InstantiationException | NoSuchMethodException | InvocationTargetException e) {
            e.printStackTrace();
        }

        return new NullCarFactory();
    }
}
