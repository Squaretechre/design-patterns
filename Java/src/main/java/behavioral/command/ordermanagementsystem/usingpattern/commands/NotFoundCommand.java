package behavioral.command.ordermanagementsystem.usingpattern.commands;

public class NotFoundCommand implements Command, CommandFactory {
    private String name;

    @Override
    public void execute() {
        System.out.println("Unknown command: " + name);
    }

    @Override
    public Command makeCommand(String[] arguments) {
        var notFoundCommand = new NotFoundCommand();
        notFoundCommand.name = arguments[0];
        return notFoundCommand;
    }

    @Override
    public String name() {
        return "Unknown Command";
    }

    @Override
    public String description() {
        return "Default when no match found for requested command";
    }
}
