using System;
using System.Collections;

namespace ObserverPattern
{
    public class WeatherData : Subject
    {
        private ArrayList observers;
        float temprature, humidity, pressure;

        public WeatherData()
        {
            observers = new ArrayList();
        }

        public void NotifyObserver()
        {
            for(int i=0; i<observers.Count; i++)
            {
                Observer observer = (Observer)observers[i];
                observer.Update(temprature, humidity, pressure);
            }
        }

        public void RegisterObserver(Observer o)
        {
            observers.Add(o);
        }

        public void RemoveObserver(Observer o)
        {
            int i = observers.IndexOf(o);
            if (i >= 0)
                observers.RemoveAt(i);
        }

        public void MeasurementsChanged()
        {
            NotifyObserver();
        }

        public void SetMeasurements(float temp,float humidity,float pressure)
        {
            this.temprature = temp;
            this.humidity = humidity;
            this.pressure = pressure;
            MeasurementsChanged();
        }
    }
}
