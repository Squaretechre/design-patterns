package behavioral.strategy.ordershippingcalculator.switchsolution;

class Order {
    final ShippingOption shippingMethod;

    Order(ShippingOption shippingMethod) {
        this.shippingMethod = shippingMethod;
    }
}
