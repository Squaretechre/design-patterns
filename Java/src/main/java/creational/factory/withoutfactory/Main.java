package creational.factory.withoutfactory;

import java.util.Scanner;

public class Main {
    public static void main(String... args) {
        Scanner in = new Scanner(System.in);
        String carName = in.nextLine();
        Auto car = GetCar(carName);
        car.turnOn();
        car.turnOff();
    }

    // Violation of OCP
    // Main must be modified whenever a new card is added
    private static Auto GetCar(String carName) {
        switch (carName) {
            case "bmw":
                return new BMW335Xi();
            case "mini":
                return new MiniCooper();
            case "audi":
                return new AudiTTS();
            default:
                return new NullCar();
        }
    }
}
