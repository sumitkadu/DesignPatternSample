using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    public class Pizza
    {
        public void Prepare()
        {
            Console.WriteLine("Preparing Pizza");
        }

        public void Bake()
        {
            Console.WriteLine("Baking Pizza");
        }

        public void Cut()
        {
            Console.WriteLine("Cutting Pizza");
        }

        public void Box()
        {
            Console.WriteLine("Boxing Pizza");
        }
    }

    public class CheesePizza : Pizza
    {

    }

    public class PepperoniPizza : Pizza
    {
    }

    public class ClamPizza : Pizza
    {
    }

    public class VeggiePizza : Pizza
    {
    }
}
