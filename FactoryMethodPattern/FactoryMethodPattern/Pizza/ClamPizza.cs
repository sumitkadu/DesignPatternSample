using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ClamPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public ClamPizza(IPizzaIngredientFactory ingradientFactory)
        {
            this.ingredientFactory = ingradientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();

            clam = ingredientFactory.CreateClam();
        }
    }
}
