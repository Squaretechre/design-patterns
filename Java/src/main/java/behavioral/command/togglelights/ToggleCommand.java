package behavioral.command.togglelights;

// concrete command
public class ToggleCommand implements Command {

    private Light light;

    public ToggleCommand(Light light) {
        this.light = light;
    }

    @Override
    // command delegates to some other object
    public void execute() {
        light.toggle();
    }
}
