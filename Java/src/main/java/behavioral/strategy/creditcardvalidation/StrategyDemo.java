package behavioral.strategy.creditcardvalidation;

public class StrategyDemo {

    public static void main(String args[]) {
        CreditCard amexCard = new CreditCard("379185883464283", "04/2020", "123", new AmexStrategy());

        System.out.println("Is Amex valid: " + amexCard.isValid());

        CreditCard amexCard2 = new CreditCard("379185883464282", "04/2017", "234", new AmexStrategy());

        System.out.println("Is Amex valid: " + amexCard2.isValid());

        CreditCard visaCard = new CreditCard("4539589763663402", "05/2018", "324", new VisaStrategy());

        System.out.println("Is Visa valid: " + visaCard.isValid());
    }
}
