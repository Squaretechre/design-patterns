package creational.factory.abstractfactory.autos;

public abstract class BMWBase implements Auto {

    @Override
    public void turnOn() {
        System.out.println(name() + " is on and running.");
    }

    @Override
    public void turnOff() {
        System.out.println(name() + " is off.");
    }

    protected abstract String name();
}
