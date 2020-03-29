package behavioral.strategy.ordershippingcalculator.switchsolution;

import static java.lang.System.out;

public class Main {
    public static void main(String... args) {
        var shippingCalculatorService = new ShippingCostCalculatorService();

        var royalMailOrder = new Order(ShippingOption.ROYAL_MAIL);
        double royalMailCost = shippingCalculatorService.calculateShippingFor(royalMailOrder);
        out.println(royalMailCost);

        var fedexOrder = new Order(ShippingOption.FEDEX);
        double fedexCost = shippingCalculatorService.calculateShippingFor(fedexOrder);
        out.println(fedexCost);

        var upsOrder = new Order(ShippingOption.UPS);
        double upsCost = shippingCalculatorService.calculateShippingFor(upsOrder);
        out.println(upsCost);
    }
}
