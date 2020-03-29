package behavioral.strategy.creditcardvalidation;

public class CreditCard {

    private String number;
    private String date;
    private String cvv;
    private ValidationStrategy strategy;

    public String getNumber() {
        return number;
    }

    public String getDate() {
        return date;
    }

    public String getCvv() {
        return cvv;
    }

    public CreditCard(String number, String date, String cvv, ValidationStrategy strategy) {
        this.number = number;
        this.date = date;
        this.cvv = cvv;
        this.strategy = strategy;
    }

    public boolean isValid() {
        return strategy.isValid(this);
    }
}
