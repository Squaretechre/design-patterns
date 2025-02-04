package behavioral.observer.messaging;

public abstract class Observer {
    protected Subject subject;
    abstract void update();
}
