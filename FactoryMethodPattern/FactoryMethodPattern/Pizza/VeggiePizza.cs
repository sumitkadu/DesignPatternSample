using System;
namespace FactoryMethodPattern
{
    internal class VeggiePizza : Pizza
    {
        IPizzaIngredientFactory ingredientFactory;

        public VeggiePizza(IPizzaIngredientFactory ingradientFactory)
        {
            this.ingredientFactory = ingradientFactory;
        }

        public override void Prepare()
        {
            Console.WriteLine("Preparing {0}", name);
            dough = ingredientFactory.CreateDough();
            sauce = ingredientFactory.CreateSauce();
            cheese = ingredientFactory.CreateCheese();

            veggies = ingredientFactory.CreateVeggies();
        }
    }
}