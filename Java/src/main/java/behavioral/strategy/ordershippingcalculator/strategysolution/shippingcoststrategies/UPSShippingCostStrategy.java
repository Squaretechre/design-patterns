package behavioral.strategy.ordershippingcalculator.strategysolution.shippingcoststrategies;

import behavioral.strategy.ordershippingcalculator.strategysolution.Order;

public class UPSShippingCostStrategy implements ShippingCostStrategy {
    @Override
    public double calculateFor(Order order) {
        return 4.25;
    }
}
