using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ITarget target = new AdapterClass();
            foreach (string product in target.GetProducts())
                Console.WriteLine(product);
            Console.ReadLine();
        }
    }

    public interface ITarget
    {
        List<string> GetProducts();
    }

    public class Adaptee
    {
        public List<string> GetProductList()
        {
            List<string> products = new List<string>();
            products.Add("Books");
            products.Add("Music");
            products.Add("Movies");
            products.Add("Mobiles");

            return products;
        }
    }

    public class AdapterClass: ITarget
    {
        public List<string> GetProducts()
        {
            Adaptee adaptee = new Adaptee();
            return adaptee.GetProductList();
        }
    }
}
