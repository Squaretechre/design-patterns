package behavioral.command.ordermanagementsystem.usingpattern.commands;

public interface CommandFactory {
    Command makeCommand(String[] arguments);
    String name();
    String description();
}
