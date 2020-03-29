package behavioral.command.togglelights;

// concrete command
public class OnCommand implements Command {

    private Light light;

    public OnCommand(Light light) {
        this.light = light;
    }

    @Override
    // command delegates to some other object
    public void execute() {
        light.on();
    }
}
