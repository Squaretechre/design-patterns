package behavioral.command.ordermanagementsystem.usingpattern;

import behavioral.command.ordermanagementsystem.usingpattern.commands.CommandFactory;
import behavioral.command.ordermanagementsystem.usingpattern.commands.CreateOrderCommand;
import behavioral.command.ordermanagementsystem.usingpattern.commands.ShipOrderCommand;
import behavioral.command.ordermanagementsystem.usingpattern.commands.UpdateQuantityCommand;

import java.util.List;

import static java.util.Arrays.asList;

public class Program2 {
    static void run(String[] args) {
        var availableCommands = getAvailableCommands();

        if (args.length == 0) {
            printUsage(availableCommands);
            return;
        }

        var parser = new CommandParser(availableCommands);
        var command = parser.parseCommand(args);
        command.execute();
    }

    private static void printUsage(List<CommandFactory> availableCommands) {
        System.out.println("Usage: LoggingDemo CommandName Arguments");
        System.out.println("Commands:");
        for (var command : availableCommands) {
           System.out.println(" " + command.description());
        }
    }

    private static List<CommandFactory> getAvailableCommands() {
        return asList(
                new CreateOrderCommand(),
                new UpdateQuantityCommand(),
                new ShipOrderCommand()
        );
    }
}
