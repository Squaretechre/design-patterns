package creational.factory.withoutfactory;

public class MiniCooper implements Auto {
    @Override
    public void turnOn() {
        System.out.println("The Mini Cooper is on! 1.6 Litres of brutal force is churning.");
    }

    @Override
    public void turnOff() {
        System.out.println("The Mini Cooper has turned off.");
    }
}
