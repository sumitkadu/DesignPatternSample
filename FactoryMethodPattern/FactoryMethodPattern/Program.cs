using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //*** Simple factory method pattern
            //SimplePizzaFactory factory = new SimplePizzaFactory();

            // Factory Method Pattern
            PizzaStore nyPizzaStore = new NYStylePizzaStore();
            nyPizzaStore.OrderPizza("Cheese");

            //PizzaStore chicagoPizzaStore = new ChicagoStylePizzaStore();
            //chicagoPizzaStore.OrderPizza("Cheese");

            Console.ReadKey();
        }
    }
}
