package behavioral.strategy.creditcardvalidation;

public class VisaStrategy extends ValidationStrategy{
    @Override
    public boolean isValid(CreditCard creditCard) {
        boolean hasValidPrefix = creditCard.getNumber().startsWith("4");
        boolean hasCorrectCardNumberLength = creditCard.getNumber().length() == 16;
        boolean passesLuhnCheck = passesLuhn(creditCard.getNumber());

        return hasValidPrefix
                && hasCorrectCardNumberLength
                && passesLuhnCheck;
    }
}
