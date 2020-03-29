package behavioral.strategy.ordershippingcalculator.strategysolution.shippingcoststrategies;

import behavioral.strategy.ordershippingcalculator.strategysolution.Order;

public class RoyalMailShippingCostStrategy implements ShippingCostStrategy {
    @Override
    public double calculateFor(Order order) {
        return 3.0;
    }
}
