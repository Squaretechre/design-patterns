package behavioral.command.ordermanagementsystem.withoutpattern;

class CommandExecutor {
    void executeCommand(String[] args) {
        switch (args[0]) {
            case "UpdateQuantity":
                UpdateQuantity(Integer.valueOf(args[1]));
                break;
            case "CreateOrder":
                CreateOrder();
                break;
            case "ShipOrder":
                ShipOrder();
                break;
            default:
                System.out.println("Unrecognised command");
                break;
        }
    }

    private void UpdateQuantity(Integer newQuantity) {
        // Simulate update a database
        var oldQuantity = 5;
        System.out.println("DATABASE: Updated");

        // Simulate logging
        System.out.println("LOG: Updated order quantity from " + oldQuantity + " to " + newQuantity);
    }

    private void ShipOrder() {
    }

    private void CreateOrder() {
    }
}
