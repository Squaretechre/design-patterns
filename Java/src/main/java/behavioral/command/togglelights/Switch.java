package behavioral.command.togglelights;

// invoker
public class Switch {

    public void storeAndExecute(Command command) {
        command.execute();
    }
}
