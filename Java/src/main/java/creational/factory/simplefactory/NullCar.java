package creational.factory.simplefactory;

public class NullCar implements Auto {
    @Override
    public void turnOn() {
        System.out.println("Whoops, null car can't turn on!");
    }

    @Override
    public void turnOff() {
        System.out.println("And can't turn off either.");
    }
}
