using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public abstract class Pizza
    {
        public String name = string.Empty;
        public Dough dough;
        public Sauce sauce;
        public List<Veggies> veggies;
        public Cheese cheese;
        public Clam clam;
        public Pepperoni pepperoni;
        
        public ArrayList toppings = new ArrayList();

        public String GetName
        {
            get
            {
                return name;
            }
        }

        public abstract void Prepare();
        
        public void Bake()
        {
            Console.WriteLine("Bake for 25 minutes at 350");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting pizza into diagonal slices");
        }

        public void Box()
        {
            Console.WriteLine("Place pizza into official PizzaStore box");
        }
    }    
}
