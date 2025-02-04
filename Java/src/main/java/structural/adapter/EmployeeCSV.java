package structural.adapter;

import java.util.StringTokenizer;

public class EmployeeCSV {
    private String firstname;
    private String lastname;
    private String emailAddress;
    private int id;

    public EmployeeCSV(String values) {
        StringTokenizer tokenizer = new StringTokenizer(values, ",");
        if(tokenizer.hasMoreElements()) {
            id = Integer.parseInt(tokenizer.nextToken());
        }
        if(tokenizer.hasMoreElements()) {
            firstname = tokenizer.nextToken();
        }
        if(tokenizer.hasMoreElements()) {
            lastname = tokenizer.nextToken();
        }
        if(tokenizer.hasMoreElements()) {
            emailAddress = tokenizer.nextToken();
        }
    }

    public String getFirstname() {
        return firstname;
    }

    public String getLastname() {
        return lastname;
    }

    public String getEmailAddress() {
        return emailAddress;
    }

    public int getId() {
        return id;
    }
}
