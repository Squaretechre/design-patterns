package creational.factory.factorymethod.autos;

public class BMWM5Cabriolet implements Auto {
    @Override
    public void turnOn() {
        System.out.println("The BMW M5 Cabriolet is up and running with a mighty whiiiiiirrrrr sound.");
    }

    @Override
    public void turnOff() {
        System.out.println("The BMW M5 Cabriolet is shutting down.");
    }
}
