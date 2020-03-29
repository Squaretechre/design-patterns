package creational.factory.simplefactory;

public class AudiTTS implements Auto {
    @Override
    public void turnOn() {
        System.out.println("The Audi TTS is running, but there is an electrical fire.");
    }

    @Override
    public void turnOff() {
        System.out.println("The Audi TTS is off, but the dashboard is still smoking.");
    }
}
