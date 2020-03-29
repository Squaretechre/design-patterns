package behavioral.strategy.ordershippingcalculator.switchsolution;

class ShippingCostCalculatorService {
    double calculateShippingFor(Order order) {
        switch (order.shippingMethod) {
            case FEDEX:
                return calculateForFedEx(order);
            case UPS:
                return calculateForUps(order);
            case ROYAL_MAIL:
                return calculateForRoyalMail(order);
            default:
                return 0;
        }
    }


    private double calculateForRoyalMail(Order order) {
        return 3.0;
    }

    private double calculateForUps(Order order) {
        return 4.25;
    }

    private double calculateForFedEx(Order order) {
        return 5.0;
    }
}
