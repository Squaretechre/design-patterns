package behavioral.command.ordermanagementsystem.usingpattern.commands;

public class ShipOrderCommand implements Command, CommandFactory {
    @Override
    public void execute() {
        System.out.println("Shipping an order");
    }

    @Override
    public String description() {
        return "ShipOrder";
    }

    @Override
    public String name() {
        return "ShipOrder";
    }

    @Override
    public Command makeCommand(String[] arguments) {
        return new ShipOrderCommand();
    }
}
