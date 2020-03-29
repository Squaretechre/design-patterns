package behavioral.observer.weatherstation;

public class CurrentConditionsDisplay implements Observer, DisplayElement {
    private final Subject weatherData;
    private float temperature;
    private float humidity;

    public CurrentConditionsDisplay(Subject weatherData) {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    @Override
    public void display() {
        String displayTemperature = noDecimalPoint(temperature);
        String displayHumidity = noDecimalPoint(humidity);
        System.out.println("Current conditions: " + displayTemperature + "F degrees and " + displayHumidity + "% humidity");
    }

    @Override
    public void update(float temp, float humidity, float pressure) {
        this.temperature = temp;
        this.humidity = humidity;
        display();
    }

    private String noDecimalPoint(float value) {
        return String.format("%.0f", value);
    }
}
