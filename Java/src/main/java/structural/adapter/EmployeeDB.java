package structural.adapter;

public class EmployeeDB {

    private String id;
    private String firstName;
    private String lastName;
    private String email;

    public EmployeeDB(String id, String firstName, String lastName, String email) {
        this.id = id;
        this.firstName = firstName;
        this.lastName = lastName;
        this.email = email;
    }

    public Employee getEmployee() {
        return new StandardEmployee(id, firstName, lastName, email);
    }
}
