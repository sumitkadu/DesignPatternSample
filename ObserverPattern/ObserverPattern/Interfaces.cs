using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    public interface Subject
    {
        void RegisterObserver(Observer o);
        void RemoveObserver(Observer o);
        void NotifyObserver();
    }

    public interface Observer
    {
        void Update(float temprature, float humidity, float pressure);
    }

    public interface DisplayElement
    {
        void Display();
    }
}
