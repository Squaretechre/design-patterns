package behavioral.strategy.ordershippingcalculator.strategysolution;

import behavioral.strategy.ordershippingcalculator.strategysolution.shippingcoststrategies.FedExShippingCostStrategy;
import behavioral.strategy.ordershippingcalculator.strategysolution.shippingcoststrategies.RoyalMailShippingCostStrategy;
import behavioral.strategy.ordershippingcalculator.strategysolution.shippingcoststrategies.UPSShippingCostStrategy;

import static java.lang.System.out;

public class Main {
    public static void main(String... args) {
        var shippingCalculatorService = new ShippingCostCalculatorService(new RoyalMailShippingCostStrategy());

        var royalMailOrder = new Order();
        double royalMailCost = shippingCalculatorService.calculateShippingFor(royalMailOrder);
        out.println(royalMailCost);

        shippingCalculatorService = new ShippingCostCalculatorService(new FedExShippingCostStrategy());

        var fedexOrder = new Order();
        double fedexCost = shippingCalculatorService.calculateShippingFor(fedexOrder);
        out.println(fedexCost);

        shippingCalculatorService = new ShippingCostCalculatorService(new UPSShippingCostStrategy());

        var upsOrder = new Order();
        double upsCost = shippingCalculatorService.calculateShippingFor(upsOrder);
        out.println(upsCost);
    }
}
