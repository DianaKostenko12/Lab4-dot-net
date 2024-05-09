using Lab4_dot_net.BeverageFactoryInterface;
using Lab4_dot_net.BeverageInterface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab4_dot_net.Factories
{
    public class EspressoFactory : IBeverageFactory
    {
        public IBeverage CreateBeverage(string size)
        {
            return new Espresso(size);
        }
    }
}
