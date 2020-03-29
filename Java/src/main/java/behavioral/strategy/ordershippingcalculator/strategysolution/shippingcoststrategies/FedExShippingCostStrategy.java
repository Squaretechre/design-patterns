package behavioral.strategy.ordershippingcalculator.strategysolution.shippingcoststrategies;

import behavioral.strategy.ordershippingcalculator.strategysolution.Order;

public class FedExShippingCostStrategy implements ShippingCostStrategy {
    @Override
    public double calculateFor(Order order) {
        return 5.0;
    }
}
