using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class CurrentConditionsDisplay : Observer, DisplayElement
    {
        float temprature, humidity;
        private Subject weatherData;

        public CurrentConditionsDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            Console.WriteLine("Current conditions: " + temprature + "F degrees and " + humidity + "% humidity");
        }

        public void Update(float temprature, float humidity, float pressure)
        {
            this.temprature = temprature;
            this.humidity = humidity;
            Display();
        }
    }
}
