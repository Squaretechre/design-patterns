package behavioral.strategy.ordershippingcalculator.strategysolution;

import behavioral.strategy.ordershippingcalculator.strategysolution.shippingcoststrategies.ShippingCostStrategy;

class ShippingCostCalculatorService {
    private final ShippingCostStrategy shippingCostStrategy;

    ShippingCostCalculatorService(ShippingCostStrategy shippingCostStrategy) {
        this.shippingCostStrategy = shippingCostStrategy;
    }

    double calculateShippingFor(Order order) {
        return shippingCostStrategy.calculateFor(order);
    }
}
