using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public class ForecastDisplay : Observer, DisplayElement
    {
        float temprature, humidity;
        private Subject weatherData;

        public ForecastDisplay(Subject weatherData)
        {
            this.weatherData = weatherData;
            weatherData.RegisterObserver(this);
        }

        public void Display()
        {
            if (temprature == 80)
                Console.WriteLine("Forecast: Improving weather on the way!");
            else if (temprature < 80)
                Console.WriteLine("Forecast: Watch out for cooler, rainy weather!");
            else
                Console.WriteLine("More of the same!");            
        }

        public void Update(float temprature, float humidity, float pressure)
        {
            this.temprature = temprature;
            this.humidity = humidity;
            Display();
        }
    }
}
