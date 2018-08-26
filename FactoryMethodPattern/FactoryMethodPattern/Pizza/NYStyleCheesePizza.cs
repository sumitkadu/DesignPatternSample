using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class NYStyleCheesePizza : Pizza
    {
        public NYStyleCheesePizza()
        {
            name = "NY Style sauce and cheese pizza";
            //sauce = "Marinara Sauce";
            //dough = "Thin Crust dough";
            //toppings.Add("Grated Reggiano Cheese");
        }

        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
