package behavioral.observer.weatherstation;

public class WeatherStation {

    public static void main(String args[]) {
        WeatherData weatherData = new WeatherData();

        new CurrentConditionsDisplay(weatherData);
        new StatisticsDisplay(weatherData);
    }
}
