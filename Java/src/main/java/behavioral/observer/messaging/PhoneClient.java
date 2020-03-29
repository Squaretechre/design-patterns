package behavioral.observer.messaging;

public class PhoneClient extends Observer{

    private final Subject subject;

    public PhoneClient(Subject subject) {
        this.subject = subject;
        subject.attach(this);
    }

    public void addMessage(String message) {
        subject.setState(message + " - sent from phone");
    }

    @Override
    void update() {
       System.out.println("Phone stream: " + subject.getState());
    }
}
