using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class NYStylePizzaStore : PizzaStore
    {
        protected override Pizza CreatePizza(string type)
        {
            Pizza pizza = null;
            IPizzaIngredientFactory ingredientFactory = new NYPizzaIngredientFactory();


            if (type.Equals("Cheese"))
            {
                pizza = new CheesePizza(ingredientFactory);
                Console.WriteLine("New york style cheese pizza");
            }
            else if (type.Equals("Pepperoni"))
            {
                pizza = new PepperoniPizza(ingredientFactory);
                Console.WriteLine("New york style pepproni pizza");
            }
            else if (type.Equals("Clam"))
            {
                pizza = new ClamPizza(ingredientFactory);
                Console.WriteLine("New york style clam pizza");
            }
            else if (type.Equals("Veggie"))
            {
                pizza = new VeggiePizza(ingredientFactory);
                Console.WriteLine("New york style veggie pizza");
            }

            return pizza;
        }
    }
}
