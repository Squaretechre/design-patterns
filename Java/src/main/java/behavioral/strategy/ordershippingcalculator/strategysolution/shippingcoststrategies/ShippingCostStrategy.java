package behavioral.strategy.ordershippingcalculator.strategysolution.shippingcoststrategies;

import behavioral.strategy.ordershippingcalculator.strategysolution.Order;

public interface ShippingCostStrategy {
    double calculateFor(Order order);
}
