using System;
namespace FactoryMethodPattern
{
    internal class PepperoniPizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public PepperoniPizza(IPizzaIngredientFactory ingradientFactory)
        {
            this.ingredientFactory = ingradientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();

            pepperoni = ingredientFactory.CreatePepperoni();
        }
    }
}