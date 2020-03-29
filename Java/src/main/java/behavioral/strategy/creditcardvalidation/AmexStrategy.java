package behavioral.strategy.creditcardvalidation;

public class AmexStrategy  extends ValidationStrategy {
    @Override
    public boolean isValid(CreditCard creditCard) {
        boolean hasValidPrefix = creditCard.getNumber().startsWith("37") || creditCard.getNumber().startsWith("34");
        boolean hasCorrectCardNumberLength = creditCard.getNumber().length() == 15;
        boolean passesLuhnCheck = passesLuhn(creditCard.getNumber());

        return hasValidPrefix
                && hasCorrectCardNumberLength
                && passesLuhnCheck;
    }
}
