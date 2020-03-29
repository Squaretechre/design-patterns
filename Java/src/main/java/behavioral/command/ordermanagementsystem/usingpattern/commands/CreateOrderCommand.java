package behavioral.command.ordermanagementsystem.usingpattern.commands;

public class CreateOrderCommand implements Command, CommandFactory {
    @Override
    public void execute() {
        System.out.println("Creating an order");
    }

    @Override
    public String description() {
        return "Creates an order";
    }

    @Override
    public String name() {
       return "CreateOrder";
    }

    @Override
    public Command makeCommand(String[] arguments) {
        return new CreateOrderCommand();
    }
}
