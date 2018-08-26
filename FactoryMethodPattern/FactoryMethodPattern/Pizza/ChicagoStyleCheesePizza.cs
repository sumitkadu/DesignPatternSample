using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ChicagoStyleCheesePizza:Pizza
    {
        public ChicagoStyleCheesePizza()
        {
            name = "Chicago Style deep dish cheese pizza";
            //sauce = "Plum tomato Sauce";
            //dough = "Extra thick crust dough";
            //toppings.Add("Shredded Mozzarella Cheese");
        }

        public new void Cut()
        {
            Console.WriteLine("Cutting pizza into square slices");
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
