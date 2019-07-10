using System;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            CaffeineDrink drink = new Coffee();
            Console.WriteLine("Making coffee");
            drink.PrepareReceipe();

            CaffeineDrink drink2 = new Tea();
            Console.WriteLine("Making tea");
            drink2.PrepareReceipe();
            Console.ReadKey();
        }
    }

    public abstract class CaffeineDrink
    {
        public void PrepareReceipe()
        {
            BoilWater();
            Brew();

            // Used hook method to alter behaviour.
            if (WantCondiments())
                AddCondiments();

            PourInCup();
        }

        public abstract void Brew();

        public abstract void AddCondiments();

        public void BoilWater()
        {
            Console.WriteLine("Boiling Water");
        }

        public void PourInCup()
        {
            Console.WriteLine("Pour in cup");
        }

        // Hook Method to alter the behaviour of algorithm. This method can be abstract or can be given default behaviour
        public bool WantCondiments()
        {
            return true;
        }

    }

    public class Coffee : CaffeineDrink
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Add Milk and Sugar");
        }

        public override void Brew()
        {
            Console.WriteLine("Brew Coffee");
        }
    }

    public class Tea : CaffeineDrink
    {
        public override void AddCondiments()
        {
            Console.WriteLine("Add Lemon");
        }

        public override void Brew()
        {
            Console.WriteLine("Dip Teabag");
        }
    }
}
