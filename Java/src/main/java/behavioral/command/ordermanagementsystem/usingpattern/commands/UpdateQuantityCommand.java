package behavioral.command.ordermanagementsystem.usingpattern.commands;

public class UpdateQuantityCommand implements Command, CommandFactory {
    private Integer newQuantity;

    @Override
    public void execute() {
        // Simulate update a database
        var oldQuantity = 5;
        System.out.println("DATABASE: Updated");

        // Simulate logging
        System.out.println("LOG: Updated order quantity from " + oldQuantity + " to " + newQuantity);
    }

    @Override
    public String description() {
        return "UpdateQuantity number";
    }

    @Override
    public String name() {
        return "UpdateQuantity";
    }

    @Override
    public Command makeCommand(String[] arguments) {
        var updateQuantityCommand = new UpdateQuantityCommand();
        updateQuantityCommand.newQuantity = Integer.valueOf(arguments[1]);
        return updateQuantityCommand;
    }
}
