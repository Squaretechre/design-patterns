package behavioral.state.fan.statesolution;

public abstract class State {
    public void handleRequest() {
        System.out.println("Shouldn't be able to get here.");
    }
}
