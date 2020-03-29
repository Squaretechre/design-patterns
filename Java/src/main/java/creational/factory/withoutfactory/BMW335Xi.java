package creational.factory.withoutfactory;

public class BMW335Xi implements Auto {
    @Override
    public void turnOn() {
        System.out.println("The BMW 335Xi is on and running");
    }

    @Override
    public void turnOff() {
        System.out.println("The BMW 335xi is off.");
    }
}
