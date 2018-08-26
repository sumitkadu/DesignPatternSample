using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class PizzaStore
    {
        //*** This is a simple factory method pattern
        //SimplePizzaFactory factory = new SimplePizzaFactory();
        //public PizzaStore(SimplePizzaFactory factory)
        //{
        //    this.factory = factory;
        //}

        public Pizza OrderPizza(string type)
        {
            Pizza pizza;

            //*** Simple factory method pattern
            //pizza = factory.CreatePizza(type);


            pizza = CreatePizza(type);
            pizza.Prepare();
            pizza.Bake();
            pizza.Cut();
            pizza.Box();

            return pizza;
        }

        protected abstract Pizza CreatePizza(string type);

    }
}
