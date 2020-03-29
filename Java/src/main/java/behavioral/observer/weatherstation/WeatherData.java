package behavioral.observer.weatherstation;

import java.util.*;

public class WeatherData implements Subject {

    private final ArrayList<Observer> observers;
    private float temperature;
    private float humidity;
    private float pressure;

    public WeatherData() {
        observers = new ArrayList<>();
        updateMeasurements();
    }

    @Override
    public void registerObserver(Observer o) {
       observers.add(o);
    }

    @Override
    public void removeObserver(Observer o) {
        int i = observers.indexOf(o);
        if(i >= 0) {
            observers.remove(i);
        }
    }

    @Override
    public void notifyObservers() {
        for(Observer observer : observers) {
           observer.update(temperature, humidity, pressure);
        }
    }

    private void updateMeasurements() {
        TimerTask repeatedTask = new TimerTask() {
            public void run() {
                Random r = new Random();
                temperature = 75 + r.nextFloat() * (80 - 75);
                humidity = 65 + r.nextFloat() * (90 - 65);
                pressure = 25 + r.nextFloat() * (30 - 25);
                notifyObservers();
            }
        };
        Timer timer = new Timer("Timer");

        long delay  = 3000L;
        long period = 3000L;
        timer.scheduleAtFixedRate(repeatedTask, delay, period);
    }
}
