package behavioral.command.ordermanagementsystem.withoutpattern;

class Program1 {
    static void run(String[] args) {
       if (args.length == 0)  {
           printUsage();
           return;
       }
       var processor = new CommandExecutor();
       processor.executeCommand(args);
    }

    private static void printUsage() {
        System.out.println("Usage: LoggingDemo CommandName Arguments");
        System.out.println("Commands:");
        System.out.println("    UpdateQuantity number");
        System.out.println("    CreateOrder");
        System.out.println("    ShipOrder");
    }
}
