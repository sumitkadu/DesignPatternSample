using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class SimplePizzaFactory
    {
        public Pizza CreatePizza(string type)
        {
            Pizza pizza = null;

            if (type.Equals("Cheese"))
                pizza = new CheesePizza();
            else if (type.Equals("Pepperoni"))
                pizza = new PepperoniPizza();
            else if (type.Equals("Clam"))
                pizza = new ClamPizza();
            if (type.Equals("Veggie"))
                pizza = new VeggiePizza();

            return pizza;
        }
    }
}
