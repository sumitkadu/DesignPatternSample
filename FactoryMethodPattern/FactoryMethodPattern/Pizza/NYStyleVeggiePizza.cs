using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class NYStyleVeggiePizza : Pizza
    {
        public override void Prepare()
        {
            throw new NotImplementedException();
        }
    }
}
