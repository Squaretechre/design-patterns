package structural.adapter;

public abstract class Employee {
    public abstract String getId();
    public abstract String getFirstName();
    public abstract String getLastName();
    public abstract String getEmail();

    @Override
    public String toString() {
        return "[ID: " + getId() + ", "
                + "First name: " + getFirstName() + ", "
                + "Last name: " + getLastName() + ", "
                + "Email: " +getEmail()
                + "]";
    }
}
