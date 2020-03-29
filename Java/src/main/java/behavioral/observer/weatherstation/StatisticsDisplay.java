package behavioral.observer.weatherstation;

import java.util.ArrayList;
import java.util.DoubleSummaryStatistics;

public class StatisticsDisplay implements Observer, DisplayElement {
    private final Subject weatherData;
    private ArrayList<Float> temperatureHistory = new ArrayList<>();

    public StatisticsDisplay(Subject weatherData) {
        this.weatherData = weatherData;
        weatherData.registerObserver(this);
    }

    @Override
    public void display() {
        DoubleSummaryStatistics stats = temperatureHistory.stream()
                .mapToDouble((x) -> x)
                .summaryStatistics();

        String displayAverage = noDecimalPoint(stats.getAverage());
        String displayMax = noDecimalPoint(stats.getMax());
        String displayMin = noDecimalPoint(stats.getMin());

        System.out.println("Avg/Max/Min temperature = "
                + displayAverage + "/"
                + displayMax + "/"
                + displayMin);
    }

    @Override
    public void update(float temp, float humidity, float pressure) {
        temperatureHistory.add(temp);
        display();
    }

    private String noDecimalPoint(double value) {
        return String.format("%.0f", value);
    }
}
