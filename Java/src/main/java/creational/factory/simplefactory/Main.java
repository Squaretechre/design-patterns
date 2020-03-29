package creational.factory.simplefactory;

import java.util.Scanner;

public class Main {
    public static void main(String... args) {
        Scanner in = new Scanner(System.in);
        String carName = in.nextLine();

        AutoFactory factory = new AutoFactory();

        Auto car = factory.createInstance(carName);

        car.turnOn();
        car.turnOff();
    }
}
