package behavioral.mediator;

// receiver
public class Light {

    private final String name;
    private boolean isOn = false;

    public Light(String name) {
        this.name = name;
    }

    public void toggle() {
        if(isOn) {
            off();
            isOn = false;
        }
        else {
            on();
            isOn = true;
        }
    }

    public boolean isOn() {
        return isOn;
    }

    public void on() {
        System.out.println(name + " light switched on.");
    }

    public void off() {
        System.out.println(name + " light switched off.");
    }
}
