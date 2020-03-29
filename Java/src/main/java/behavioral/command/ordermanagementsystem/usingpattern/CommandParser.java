package behavioral.command.ordermanagementsystem.usingpattern;

import behavioral.command.ordermanagementsystem.usingpattern.commands.Command;
import behavioral.command.ordermanagementsystem.usingpattern.commands.CommandFactory;
import behavioral.command.ordermanagementsystem.usingpattern.commands.NotFoundCommand;

import java.util.List;

class CommandParser {
    private final List<CommandFactory> availableCommands;

    CommandParser(List<CommandFactory> availableCommands) {
        this.availableCommands = availableCommands;
    }

    Command parseCommand(String[] args) {
        var requestedCommandName = args[0];
        var command = findRequestedCommand(requestedCommandName);
        return command.makeCommand(args);
    }

    private CommandFactory findRequestedCommand(String requestedCommandName) {
        return availableCommands.stream()
                .filter(c -> c.name().equals(requestedCommandName))
                .findFirst()
                .orElse(new NotFoundCommand());
    }
}
