using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class NYStylePepperoniPizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
