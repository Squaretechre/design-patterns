package behavioral.command.togglelights;

import java.util.ArrayList;
import java.util.List;

public class CommandDemo {
    public static void main(String args[]) {
        // receiver
        Light bedroomLight = new Light();
        Light kitchenLight = new Light();

        // invoker
        Switch lightSwitch = new Switch();

        Command toggleCommand = new ToggleCommand(bedroomLight);

        lightSwitch.storeAndExecute(toggleCommand);
        lightSwitch.storeAndExecute(toggleCommand);
        lightSwitch.storeAndExecute(toggleCommand);

        List<Light> lights = new ArrayList<>();
        lights.add(kitchenLight);
        lights.add(bedroomLight);

        Command allLightsCommand = new AllLightsCommand(lights);
        lightSwitch.storeAndExecute(allLightsCommand);
    }
}
