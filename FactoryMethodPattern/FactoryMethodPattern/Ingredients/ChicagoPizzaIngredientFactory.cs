using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ChicagoPizzaIngredientFactory : IPizzaIngredientFactory
    {
        public Cheese CreateCheese()
        {
            throw new NotImplementedException();
        }

        public Clam CreateClam()
        {
            throw new NotImplementedException();
        }

        public Dough CreateDough()
        {
            throw new NotImplementedException();
        }

        public Pepperoni CreatePepperoni()
        {
            throw new NotImplementedException();
        }

        public Sauce CreateSauce()
        {
            throw new NotImplementedException();
        }

        public List<Veggies> CreateVeggies()
        {
            throw new NotImplementedException();
        }
    }
}
