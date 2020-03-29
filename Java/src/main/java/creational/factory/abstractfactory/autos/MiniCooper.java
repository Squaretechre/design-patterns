package creational.factory.abstractfactory.autos;

public class MiniCooper implements Auto {
    private final String name;

    public MiniCooper(String name) {
        this.name = name;
    }

    @Override
    public void turnOn() {
        System.out.println(name + " is on! 1.6 Litres of brutal force is churning.");
    }

    @Override
    public void turnOff() {
        System.out.println(name + " has turned off.");
    }
}
