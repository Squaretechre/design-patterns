package structural.bridge.movieprinter;

public class Movie {
    private final String classification;
    private final String title;
    private final String runtime;
    private final String year;

    public Movie(String classification, String title, String runtime, String year) {
        this.classification = classification;
        this.title = title;
        this.runtime = runtime;
        this.year = year;
    }

    public String getClassification() {
        return classification;
    }

    public String getTitle() {
        return title;
    }

    public String getRuntime() {
        return runtime;
    }

    public String getYear() {
        return year;
    }
}
