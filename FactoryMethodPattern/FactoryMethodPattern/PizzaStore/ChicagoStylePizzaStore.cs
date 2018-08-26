using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ChicagoStylePizzaStore: PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            if (type.Equals("Cheese"))
                return new ChicagoStyleCheesePizza();
            else if (type.Equals("Pepperoni"))
                return new ChicagoStylePepperoniPizza();
            else if (type.Equals("Clam"))
                return new ChicagoStyleClamPizza();
            else if (type.Equals("Veggie"))
                return new ChicagoStyleVeggiePizza();
            else
                return null;
        }
    }
}
